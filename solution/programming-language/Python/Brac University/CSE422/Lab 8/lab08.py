#!/usr/bin/env python
# coding: utf-8

# In[18]:


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


# In[19]:


feature.head(3)


# In[20]:


label.head(3)


# In[21]:


feature.info()


# In[22]:


from sklearn.model_selection import train_test_split

X_train, X_test, y_train, y_test = train_test_split(feature, label, test_size=0.2, random_state=42)


# In[23]:


y_train


# In[24]:


from sklearn.svm import SVC
from sklearn.metrics import accuracy_score

svc = SVC(kernel="linear")
svc.fit(X_train, y_train)
predictions_svc_pre = svc.predict(X_test)
accuracy_svc_pre = accuracy_score(y_test, predictions_svc_pre)
accuracy_svc_pre


# In[25]:


from sklearn.ensemble import RandomForestClassifier
rfc = RandomForestClassifier(n_estimators=50)
rfc.fit(X_train, y_train)
predictions_random_tree_pre = rfc.predict(X_test)
accuracy_random_tree_pre = accuracy_score(y_test, predictions_random_tree_pre)
accuracy_random_tree_pre


# In[26]:


from sklearn.neural_network import MLPClassifier
nnc=MLPClassifier(hidden_layer_sizes=(9), activation="relu", max_iter=10000)
nnc.fit(X_train, y_train)
predictions_neural_pre = nnc.predict(X_test)
accuracy_multilayer_pre = accuracy_score(y_test, predictions_neural_pre)
accuracy_multilayer_pre


# In[27]:


from sklearn.decomposition import PCA 
length_of_feature_column = feature.shape[1]
pca = PCA(n_components=int(length_of_feature_column / 2))
principal_components= pca.fit_transform(feature.values)
principal_df = pd.DataFrame(data=principal_components, columns=["principle component 1", "principle component 2", "principle component 3", "principle component 4", "principle component 5"])
main_df=pd.concat([principal_df, label], axis=1)
main_df


# In[28]:


from sklearn.model_selection import train_test_split

X_train, X_test, y_train, y_test = train_test_split(principal_df, label, test_size=0.2, random_state=42)


# In[29]:


from sklearn.svm import SVC
from sklearn.metrics import accuracy_score

svc = SVC(kernel="linear")
svc.fit(X_train, y_train)
predictions_svc_post = svc.predict(X_test)
accuracy_svc_post = accuracy_score(y_test, predictions_svc_post)
accuracy_svc_post


# In[30]:


from sklearn.ensemble import RandomForestClassifier
rfc = RandomForestClassifier(n_estimators=50)
rfc.fit(X_train, y_train)
predictions_random_tree_post = rfc.predict(X_test)
accuracy_random_tree_post = accuracy_score(y_test, predictions_random_tree_post)
accuracy_random_tree_post


# In[31]:


from sklearn.neural_network import MLPClassifier
nnc=MLPClassifier(hidden_layer_sizes=(9), activation="relu", max_iter=10000)
nnc.fit(X_train, y_train)
predictions_neural_post = nnc.predict(X_test)
accuracy_multilayer_post = accuracy_score(y_test, predictions_neural_post)
accuracy_multilayer_post


# In[32]:


accuracy_df = pd.DataFrame({"accuracy_name":["Accuracy svc pre","Accuracy svc post", "Accuracy_random_tree pre", "Accuracy_random_tree post", "Accuracy multilayer pre", "Accuracy_multilayer post"], 
              "category":[accuracy_svc_pre, accuracy_svc_post, accuracy_random_tree_pre, accuracy_random_tree_post, accuracy_multilayer_pre, accuracy_multilayer_post], 
              "Type":["svc", "svc", "random", "random", "neural", "neural"]})
accuracy_df


# In[34]:


import seaborn as sns
from matplotlib import pyplot as plt
plt.title("Accuracy Comparision")
sns.set(rc={'figure.figsize':(16,8.27)})
sns.barplot(x="accuracy_name", y = "category", data = accuracy_df, hue = "Type")


# In[ ]:




