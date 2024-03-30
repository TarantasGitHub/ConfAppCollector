Для запуска docker-compose и получения доступа к web снаружи нужно:
1. запустить docker-compose build;
2. выполнить docker run --rm -p 8080:8080 --name conf conf-collector.api
3. первый порт можно изменить на нужный, второй это тот, который прописан для контейнера в docker-compose