# funfooding
 Development environment setup

SQL:

1a. Create a database named ThreeSixtyTwo. 
1b. Run the SQL scripts in sqlscripts folder(Step1 & Step2).

2a. Move the Solr folder to c:\
2b. run the run.bat file in solr/example folder. 
2c. Modify database name/username/password in C:\solr\example\solr\collection1\conf\data-config.xml
2d. Check dataimport functionality in http://localhost:8983/solr/ 

3a. Make Sure MealPhotos and ProfilePhotos have write permission.
http://www.iis.net/learn/manage/configuring-security/application-pool-identities
3b. Modify database name/username/password in \..\funfooding\web.config
3b. Build the solution and run

#github checkin

cd C:/Users/../../../funfooding


git init
git add .
git commit -m "message on files to be pushed"
git push -u origin master


http://guides.railsgirls.com/github/