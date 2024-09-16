# Estágio de desenvolvimento
FROM node:18-alpine as development

WORKDIR /app

COPY package.json .
RUN npm install

EXPOSE 5173

CMD ["npm", "run", "dev", "--", "--host"]

# Estágio de produção
FROM node:18-alpine as production

WORKDIR /app

COPY package.json .
RUN npm install

COPY . .
RUN npm run build

RUN npm install -g serve

EXPOSE 3000

CMD ["serve", "-s", "dist"]