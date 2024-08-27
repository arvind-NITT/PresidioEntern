#!/usr/bin/env python
# coding: utf-8

# In[1]:


import pandas as pd
from pyspark.sql import SparkSession


# In[12]:


# Initialize SparkSession
spark = SparkSession.builder     .appName("YourAppName")     .config("spark.driver.memory", "4g")     .getOrCreate()

# Path to your XLSX file
file_path = "C:/Users/SUNDRAM/Downloads/complete.xlsx"

# Read the XLSX file into a Pandas DataFrame
pandas_df = pd.read_excel(file_path)

# Convert the Pandas DataFrame to a PySpark DataFrame
spark_df = spark.createDataFrame(pandas_df)




# In[25]:


pandas_df['Name of State / UT'] = pandas_df['Name of State / UT'].str.lower()


# In[27]:


# Group by the 'Date' column and sum the 'Cases' column
df_grouped = pandas_df.groupby('Date')['New cases'].sum().reset_index()

# Find the date with the maximum number of cases
max_cases_day = df_grouped[df_grouped['New cases'] == df_grouped['New cases'].max()]


# In[28]:


df_sorted = df_grouped.sort_values(by='New cases', ascending=False)

# Select the state with the second-largest number of cases
second_largest_state = df_sorted.iloc[1] 


# In[30]:



# Convert the 'Death' column to numeric, forcing errors to NaN
pandas_df['Death'] = pd.to_numeric(pandas_df['Death'], errors='coerce')

# List of Union Territories (adjust based on your data)
union_territories = [
    'delhi', 'puducherry', 'chandigarh', 'lakshadweep',
    'andaman and nicobar islands', 'daman and diu', 
    'dadra and nagar haveli', 'ladakh', 'jammu and kashmir'
]

# Filter the DataFrame to include only Union Territories
pandas_df_uts = pandas_df[pandas_df['Name of State / UT'].isin(union_territories)]

# Group by 'State' (Union Territory) and sum the 'Death' column
pandas_df_grouped_uts = pandas_df_uts.groupby('Name of State / UT')['Death'].sum().reset_index()

# Sort the Union Territories by the total number of deaths in ascending order
pandas_df_sorted_uts = pandas_df_grouped_uts.sort_values(by='Death', ascending=True)

# Select the Union Territory with the least number of deaths
least_deaths_ut = pandas_df_sorted_uts.iloc[0]  # iloc[0] gives the first row (least number of deaths)

# Show the result
print(least_deaths_ut)


# In[33]:


# Assuming 'Death' and 'Total Confirmed Cases' columns exist in the DataFrame
# Convert to numeric, forcing errors to NaN
pandas_df['Death'] = pd.to_numeric(pandas_df['Death'], errors='coerce')
pandas_df['Total Confirmed cases'] = pd.to_numeric(pandas_df['Total Confirmed cases'], errors='coerce')

# Calculate the death-to-confirmed cases ratio
pandas_df['Death to Confirmed Ratio'] = pandas_df['Death'] / pandas_df['Total Confirmed cases']

# Remove rows with NaN in the ratio column (due to division by zero or missing data)
pandas_df = pandas_df.dropna(subset=['Death to Confirmed Ratio'])

# Find the state with the lowest death-to-confirmed ratio
lowest_ratio_state = pandas_df.loc[pandas_df['Death to Confirmed Ratio'].idxmin()]

# Show the result
print(lowest_ratio_state[['Name of State / UT', 'Death', 'Total Confirmed cases', 'Death to Confirmed Ratio']])


# In[35]:


# Convert 'Recovery Date' to datetime
pandas_df['Date'] = pd.to_datetime(pandas_df['Date'], errors='coerce')

# Extract month and year from the recovery date
pandas_df['Month'] = pandas_df['Date'].dt.to_period('M')

# Group by month and sum the newly recovered cases
monthly_recovered = pandas_df.groupby('Month')['New recovered'].sum().reset_index()

# Find the month with the maximum newly recovered cases
max_recovered_month = monthly_recovered.loc[monthly_recovered['New recovered'].idxmax()]
month_mapping = {
    1: 'January', 2: 'February', 3: 'March', 4: 'April',
    5: 'May', 6: 'June', 7: 'July', 8: 'August',
    9: 'September', 10: 'October', 11: 'November', 12: 'December'
}

# Get the month number from the Period object and map it to the name
month_number = max_recovered_month['Month'].month
month_name = month_mapping[month_number]

# Show the result
print(f"Month with the most newly recovered cases: {month_name}, Total New Recovered: {max_recovered_month['New recovered']}")


# In[ ]:




