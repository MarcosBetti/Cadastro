CREATE TABLE CLIENTES( ID_CODIGO INT PRIMARY KEY NOT NULL,
                       NOME VARCHAR(40),
					   EMAIL VARCHAR(30),
					   TELEFONE VARCHAR(30),
					   ENDERECO VARCHAR(40),
					   DATANASC DATE
					   )

					  


					  Select NOME, * FROM CLIENTES 