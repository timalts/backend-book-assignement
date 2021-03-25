# backend-book-assignement

Assignement due for the 25/03 in the back-end class. Purpose is to help us improve our group work.

## Branch name explanation

pl => Pierre-Louis Garnerone
emeric => Emeric DuGardin
tim => Timothé Noël

## Deploy to heroku
```
heroku login
heroku container:login

docker build -t dorset-api .
docker tag dorset-api registry.heroku.com/dorset-api/web
docker push registry.heroku.com/dorset-api/web
heroku container:push web -a dorset-api
heroku container:release web -a dorset-api
```