FROM node:20-alpine

WORKDIR /app


COPY package.json /app

Run npm install

COPY . /app

EXPOSE 3232

CMD ["npm","run","dev"]