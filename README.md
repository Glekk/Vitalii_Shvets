# Vitalii_Shvets
WebApi homework to upload, delete and get metadata of files from dropbox  

To run this project you need to get dropbox token and put into Support/Setings.cs file, also you need to specify your own paths to files if it is needed.  

How to get token you can read here: https://developers.dropbox.com/oauth-guide#implementing-oauth  

To run project from command line you need to go to the project folder and run command: dotnet test 

And to generate test report you neet to run command (with your own paths to files):  
livingdoc test-assembly C:\Users\Vitaliy\Desktop\3_course\SDT\WebAPI\Vitalii_Shvets\WebAPI\WebAPI\bin\Debug\net6.0\WebAPI.dll -t C:\Users\Vitaliy\Desktop\3_course\SDT\WebAPI\Vitalii_Shvets\WebAPI\WebAPI\bin\Debug\net6.0\TestExecution.json  

How to install LivingDoc you can read here: https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html  
