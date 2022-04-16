#!/usr/bin/env python
# coding: utf-8

# In[38]:


import numpy as np
import pandas as pd
#Loading the DataFrame
heart_disease_dataset = pd.read_csv('heart disease classification dataset.csv')
del heart_disease_dataset["Unnamed: 0"]
#print(heart_disease_dataset.head(5))
#Checking missing values
#print(heart_disease_dataset.isnull().sum())
#Handelling the Missing Values
from sklearn.impute import SimpleImputer

impute = SimpleImputer(missing_values=np.nan, strategy='mean')

impute.fit(heart_disease_dataset[["trestbps"]])

heart_disease_dataset[["trestbps"]] = impute.transform(heart_disease_dataset[["trestbps"]])




impute.fit(heart_disease_dataset[["chol"]])

heart_disease_dataset[["chol"]] = impute.transform(heart_disease_dataset[["chol"]])


heart_disease_dataset["thalach"].fillna(int(np.mean(heart_disease_dataset["thalach"])), inplace = True)

#No null values are present
#print(heart_disease_dataset.isnull().sum())
#Encoding categorical features of sex and target column
from sklearn.preprocessing import LabelEncoder

enc = LabelEncoder()

heart_disease_dataset["sex"] = enc.fit_transform(heart_disease_dataset["sex"])


enc = LabelEncoder()
heart_disease_dataset["target"] = enc.fit_transform(heart_disease_dataset["target"])

#male - 1
#female - 0
#print(heart_disease_dataset[["sex"]])

#yes - 1
#no - 0
#print(heart_disease_dataset[["target"]])

#Checking the sex and target columns
#print(heart_disease_dataset)

#Scaling all the values between 0-1
from sklearn.preprocessing import MinMaxScaler

scaler = MinMaxScaler()

scaler.fit(heart_disease_dataset)

heart_disease_dataset_scaled = scaler.transform(heart_disease_dataset)
heart_disease_dataset_scaled = pd.DataFrame(heart_disease_dataset_scaled, columns = ['age', 'sex', 'cp', 'trestbps', 'chol', 'fbs', 'restecg', 'thalach',
       'exang', 'oldpeak', 'slope', 'ca', 'thal', 'target'])
#print(heart_disease_dataset_scaled)

#Separating features
feature = heart_disease_dataset_scaled.loc[:,'trestbps':'thal']
label = heart_disease_dataset_scaled['target']


# In[39]:


feature.head(3)


# In[40]:


label.head(3)


# In[41]:


from sklearn.model_selection import train_test_split

X_train, X_test, y_train, y_test = train_test_split(feature, label, test_size=0.2, random_state=42)


# In[42]:


import matplotlib.pyplot as plt
import seaborn as sns
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import classification_report
from sklearn.metrics import accuracy_score
from sklearn.model_selection import train_test_split
from sklearn.tree import DecisionTreeClassifier


# In[60]:


#Logistic Regression
model = LogisticRegression()
model.fit(X_train, y_train)
predictions_logistic = model.predict(X_test)
#Classification
print("Classification of logistic regression")
print(predictions_logistic)
print()
#Accuracy
accuracy_logistic = accuracy_score(y_test, predictions)
print("Accuracy of logistic " , accuracy_logistic)


# In[61]:


clf = DecisionTreeClassifier(criterion='entropy',random_state=1)
clf.fit(X_train,y_train)

predictions_decision_tree = clf.predict(X_test)
#Classification
print("Classification of Decision Tree")
print(predictions_decision_tree)
print()
#Accuracy
accuracy_decision_tree = accuracy_score(predictions_decision_tree, y_test)
print("Accuracy of decision tree ", accuracy_decision_tree)


# In[64]:


plt.title("Accuracy Comparison")
sns.barplot( x = ["Accuracy of logistic Regression", "Accuracy of decision tree"], y = [accuracy_logistic, accuracy_decision_tree])



