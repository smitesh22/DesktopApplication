import numpy as np
import pickle
import nltk
import re
import psycopg2

conn = psycopg2.connect(host="localhost",database="website",user="postgres",password="Smitesh98.*")
cur = conn.cursor()
features = np.load("features.npy")
model = pickle.load(open("model.sav", 'rb'))

wpt = nltk.WordPunctTokenizer()
stop_words = nltk.corpus.stopwords.words('english')

def normalize_document(doc):
    # lower case and remove special characters\whitespaces
    doc = re.sub(r'[^a-zA-Z\s]', '', doc, re.I|re.A)
    doc = doc.lower()
    doc = doc.strip()
    # tokenize document
    tokens = wpt.tokenize(doc)
    # filter stopwords out of document
    filtered_tokens = [token for token in tokens if token not in stop_words]
    # re-create document from filtered tokens
    doc = ' '.join(filtered_tokens)
    return doc

def predict(text):
    data = normalize_document(text)
    out = [0 for i in range(0,200)]
    for idx,word in (enumerate(features)):
        if word in data:
            out[idx] = 1
    
    
    return [out]

cur.execute("UPDATE flagged set count = 0;")
cur.execute("SELECT * FROM blog_post;")

result = cur.fetchall()

for res in result:
	a = model.predict(predict(res[2]))
	if a[0] == 1:
		cur.execute("SELECT count(*) FROM flagged WHERE flagged.id = "+str(res[4]))
		if cur.fetchall() == [(0,)]:
			cur.execute("INSERT INTO flagged VALUES(%s,%s);",(res[4],1))
			conn.commit()
		else:
			cur.execute("UPDATE flagged SET count = count + 1 WHERE id = "+str(res[4]))
			conn.commit()

conn.close()
