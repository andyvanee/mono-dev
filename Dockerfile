FROM mono

RUN apt update && apt install -y build-essential

WORKDIR /app
