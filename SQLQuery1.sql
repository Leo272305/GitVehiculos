CREATE TABLE Jugador (
    ID_Jugador INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Fecha_Nacimiento DATE,
    Ranking INT
);

CREATE TABLE Torneo (
    ID_Torneo INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Fecha_Inicio DATE,
    Fecha_Fin DATE,
    Ubicación VARCHAR(100)
);

CREATE TABLE Partida (
    ID_Partida INT PRIMARY KEY,
    ID_Torneo INT,
    ID_Jugador_Blanco INT,
    ID_Jugador_Negro INT,
    Resultado VARCHAR(10),
    Fecha DATE,
    FOREIGN KEY (ID_Torneo) REFERENCES Torneo(ID_Torneo),
    FOREIGN KEY (ID_Jugador_Blanco) REFERENCES Jugador(ID_Jugador),
    FOREIGN KEY (ID_Jugador_Negro) REFERENCES Jugador(ID_Jugador)
);

CREATE TABLE Club (
    ID_Club INT PRIMARY KEY,
    Nombre_Club VARCHAR(100),
    Ubicación VARCHAR(100),
    Fecha_Fundación DATE
);

CREATE TABLE Miembro (
    ID_Miembro INT PRIMARY KEY,
    ID_Jugador INT,
    ID_Club INT,
    Fecha_Inscripción DATE,
    Cargo VARCHAR(50),
    FOREIGN KEY (ID_Jugador) REFERENCES Jugador(ID_Jugador),
    FOREIGN KEY (ID_Club) REFERENCES Club(ID_Club)
);

CREATE TABLE Entrenador (
    ID_Entrenador INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Especialidad VARCHAR(100)
);

CREATE TABLE Sesión_de_Entrenamiento (
    ID_Sesión INT PRIMARY KEY,
    ID_Entrenador INT,
    Fecha DATE,
    Temática VARCHAR(100),
    FOREIGN KEY (ID_Entrenador) REFERENCES Entrenador(ID_Entrenador)
);

CREATE TABLE Equipo (
    ID_Equipo INT PRIMARY KEY,
    Nombre_Equipo VARCHAR(100),
    ID_Torneo INT,
    FOREIGN KEY (ID_Torneo) REFERENCES Torneo(ID_Torneo)
);

CREATE TABLE Resultado_Torneo (
    ID_Resultados INT PRIMARY KEY,
    ID_Torneo INT,
    ID_Jugador INT,
    Posición INT,
    FOREIGN KEY (ID_Torneo) REFERENCES Torneo(ID_Torneo),
    FOREIGN KEY (ID_Jugador) REFERENCES Jugador(ID_Jugador)
);
