# Logs no .NET Core 3.1 com Elastick Stack

Exemplo de lançamento de mensagens de log com .NET Core 3.1 e Elastic Stack

Para testar o projeto você precisa executar uma instância do Elastic Stack. Caso você não tenha uma máquina que já esteja rodando as ferramentas do Elastic Stack, sugiro utilizar o Docker, com Docker compose, para rodar o Logstash, o Elastic Searck e o Kinana, seguindo as instrções do repositório do Antoine Cotten.
Acesse o repositório <b>The Elastic stack (ELK) powered by Docker and Compose</b> e siga as instruções: https://github.com/rlealleandro/docker-elk

Caso esteja utilizando o projeto do Antoine Cotten, acesse a pasta /logstash/pipeline e altere o arquivo logstash.conf

Troque o input do arquivo de:

<pre>
input {
	tcp {
		port => 5000
	}
}
</pre>

para:

<pre>
input {
	http {
		port => 5000
	}
}
</pre>

<blockquote>
  <g-emoji class="g-emoji" alias="warning" fallback-src="https://github.githubassets.com/images/icons/emoji/unicode/26a0.png">⚠️</g-emoji>
  Esta alteração é apenas para teste da solução. Caso queira utilizar o projeto do Antoine Cotten em um cenário produtivo, escolha a configuração que mais se adeque ao seu projeto.
</blockquote>
