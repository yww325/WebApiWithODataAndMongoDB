# WebApiWithODataAndMongoDB
an example with asp.net core 2.2 and oData and MongoDB

import the json data in "testdb" folder to your local mongo db named "testdb"

all the following URL should work:
without version(using default version)
https://localhost:44314/odata/Books?$orderby=year
https://localhost:44314/odata/Books/?$orderby=year
or with version
https://localhost:44314/odata/Books/v1/?$orderby=year
https://localhost:44314/odata/Books?api-version=1.0&$orderby=year