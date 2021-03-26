# backend-book-assignement

Assignement due for the 25/03 in the back-end class. Purpose is to help us improve our group work.

## Branch name explanation

pl => Pierre-Louis Garnerone  
emeric => Emeric DuGardin   
tim => Timothé Noël  
nathan => Nathan Ave  

## Deploy to heroku
```
heroku login
heroku container:login

docker build -t backend-book-assignement .
docker tag backend-book-assignement registry.heroku.com/backend-book-assignement/web
docker push registry.heroku.com/backend-book-assignement/web
heroku container:push web -a backend-book-assignement
heroku container:release web -a backend-book-assignement
```
