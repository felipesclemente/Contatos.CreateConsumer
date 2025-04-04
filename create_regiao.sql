CREATE TABLE Regiao (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    DDD INT NOT NULL,
    Zona VARCHAR(100) NOT NULL,
    UF VARCHAR(2) NOT NULL
);

INSERT INTO Regiao (DDD, Zona, UF) VALUES
(11, 'Sudeste', 'SP'),
(12, 'Sudeste', 'SP'),
(13, 'Sudeste', 'SP'),
(14, 'Sudeste', 'SP'),
(15, 'Sudeste', 'SP'),
(16, 'Sudeste', 'SP'),
(17, 'Sudeste', 'SP'),
(18, 'Sudeste', 'SP'),
(19, 'Sudeste', 'SP'),
(21, 'Sudeste', 'RJ'),
(22, 'Sudeste', 'RJ'),
(24, 'Sudeste', 'RJ'),
(27, 'Sudeste', 'ES'),
(28, 'Sudeste', 'ES'),
(31, 'Centro-Oeste', 'MG'),
(32, 'Centro-Oeste', 'MG'),
(33, 'Centro-Oeste', 'MG'),
(34, 'Centro-Oeste', 'MG'),
(35, 'Centro-Oeste', 'MG'),
(37, 'Centro-Oeste', 'MG'),
(38, 'Centro-Oeste', 'MG'),
(41, 'Sul', 'PR'),
(42, 'Sul', 'PR'),
(43, 'Sul', 'PR'),
(44, 'Sul', 'PR'),
(45, 'Sul', 'PR'),
(46, 'Sul', 'PR'),
(47, 'Sul', 'SC'),
(48, 'Sul', 'SC'),
(49, 'Sul', 'SC'),
(51, 'Sul', 'RS'),
(53, 'Sul', 'RS'),
(54, 'Sul', 'RS'),
(55, 'Sul', 'RS'),
(61, 'Centro-Oeste', 'DF'),
(62, 'Centro-Oeste', 'GO'),
(63, 'Centro-Oeste', 'TO'),
(64, 'Centro-Oeste', 'GO'),
(65, 'Centro-Oeste', 'MT'),
(66, 'Centro-Oeste', 'MT'),
(67, 'Centro-Oeste', 'MS'),
(68, 'Norte', 'AC'),
(69, 'Norte', 'RO'),
(71, 'Nordeste', 'BA'),
(73, 'Nordeste', 'BA'),
(74, 'Nordeste', 'BA'),
(75, 'Nordeste', 'BA'),
(77, 'Nordeste', 'BA'),
(79, 'Nordeste', 'SE'),
(81, 'Nordeste', 'PE'),
(82, 'Nordeste', 'AL'),
(83, 'Nordeste', 'PB'),
(84, 'Nordeste', 'RN'),
(85, 'Nordeste', 'CE'),
(86, 'Nordeste', 'PI'),
(87, 'Nordeste', 'PE'),
(88, 'Nordeste', 'CE'),
(89, 'Nordeste', 'PI'),
(91, 'Norte', 'PA'),
(92, 'Norte', 'AM'),
(93, 'Norte', 'PA'),
(94, 'Norte', 'PA'),
(95, 'Norte', 'RR'),
(96, 'Norte', 'AP'),
(97, 'Norte', 'AM'),
(98, 'Nordeste', 'MA'),
(99, 'Nordeste', 'MA');
