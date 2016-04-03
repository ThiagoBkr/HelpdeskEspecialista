CREATE TABLE Chamado (Id INT IDENTITY, Descricao VARCHAR(200) NOT NULL, ProblemaId INT, NumPatrimonioPC VARCHAR(80), DataInclusao DATETIME, DataConclusao DATETIME, Solucao VARCHAR(200), CONSTRAINT pk_ChamadoID PRIMARY KEY (Id));
CREATE TABLE Problema (Id INT IDENTITY, Descricao VARCHAR(200) NOT NULL, CONSTRAINT pk_ProblemaID PRIMARY KEY (Id));
CREATE TABLE Sintoma (Id INT IDENTITY, Descricao VARCHAR(200) NOT NULL, CONSTRAINT pk_SintomaID PRIMARY KEY (Id));
CREATE TABLE ProblemaSintoma (Id INT IDENTITY, ProblemaId INT, SintomaId INT, CONSTRAINT pk_ProblemaSintomaID PRIMARY KEY (Id));
CREATE TABLE SintomaLog (Id INT IDENTITY, ProblemaSintomaId INT, SeUtil SMALLINT CONSTRAINT pk_SintomaLogID PRIMARY KEY (Id));

ALTER TABLE Chamado ADD CONSTRAINT fk_ChamadoXProblema FOREIGN KEY (ProblemaId) REFERENCES Problema (Id);
ALTER TABLE ProblemaSintoma ADD CONSTRAINT fk_ProblemaSintomaXProblema FOREIGN KEY (ProblemaId) REFERENCES Problema (Id);
ALTER TABLE ProblemaSintoma ADD CONSTRAINT fk_ProblemaSintomaXSintoma FOREIGN KEY (SintomaId) REFERENCES Sintoma (Id);
ALTER TABLE SintomaLog ADD CONSTRAINT fk_SintomaLogXProblemaSintoma FOREIGN KEY (ProblemaSintomaId) REFERENCES ProblemaSintoma (Id);