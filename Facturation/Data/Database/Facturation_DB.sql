create database Facturation_DB
use Facturation_DB

create table ADMINN
(
id int primary key , 
nom varchar(20),
prenom varchar(20),
email varchar(20),
mdp varchar(20)
)

create table SECRETAIRE
(
id int primary key , 
nom varchar(20),
prenom varchar(20),
email varchar(20),
mdp varchar(20)
)

create table VILLE
(
IdVille int primary key identity,
LblVille varchar(50),
)

create table CLIENT
(
NumeroSerie varchar(20) primary key,
NumeroTelephoneClient varchar(20) unique,
NomAgenceOuClient varchar(50),
Id_Class# int foreign key references VILLE,
)

create table CODE_ERREUR
(
IdErreur varchar(4) primary key,
LblErreur varchar(50),
)

create table TYPE_APPEL
(
IdTypeAppel varchar(4) primary key,
LblTypeAppel varchar(50),
)

create table PIECE
(
RefPiece varchar(10) primary key,
LblPiece varchar(50),
Prix float,
)

create table CODE_REPARATION
(
IdCodeReparation varchar(4) primary key,
LblReparation varchar(50),
)

create table APPEL
(
IdAppel int primary key identity,
DateEtHeurAppel datetime,
IdClient# varchar(20) foreign key references CLIENT,
DescriptionAppel varchar(200),
)

create table JOIN_APPEL_TYPEAPPEL
(
IdAppel# int foreign key references APPEL,
IdTypeAppel# varchar(4) foreign key references TYPE_APPEL,
primary key(IdAppel#,IdTypeAppel#),
)

create table INGENIEUR
(
IdIngenieur int primary key identity,
noming varchar(20),
prenom varchar(20),
NumeroTelephoneIngenieur varchar(20) unique,
)

create table REPARATION
(
IdReparation int primary key identity,
DateEtHeurDepartIngenieur datetime,
DateEtHeurArriveIngenieur datetime,
DateEtHeurDebutService datetime,
DateEtHeurFinService datetime,
TempsPause int,
HeurePause time,
DescriptionTravaux varchar(1000),
IdIngenieur# int foreign key references INGENIEUR,
)

create table FACTURATION
(
IdFacture int primary key,
IdReparation# int foreign key references REPARATION,
IdAppel# int foreign key references APPEL,
EstImprime bit,
)

create table JOIN_FACTURATION_CODEERREUR
(
IdFacture# int foreign key references FACTURATION,
IdErreur# varchar(4) foreign key references CODE_ERREUR,
primary key(IdFacture#,IdErreur#),
)

create table JOIN_REPARATION_CODEREPARATION
(
IdReparation# int foreign key references REPARATION,
IdCodeReparation# varchar(4) foreign key references CODE_REPARATION,
primary key(IdReparation#,IdCodeReparation#),
)

create table JOIN_REPARATION_PIECE
(
RefPiece# varchar(10) foreign key references Piece,
IdReparation# int foreign key references REPARATION,
primary key(RefPiece#,IdReparation#),
)

SET IDENTITY_INSERT [dbo].[VILLE] ON 
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (1, N'Oujda')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (2, N'Rabat')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (3, N'Marrakech')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (4, N'CasaBlanka')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (5, N'Agadir')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (6, N'Tiznit')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (7, N'Berkan')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (8, N'Nador')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (9, N'Ahfir')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (10, N'Fes')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (11, N'Tanger')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (12, N'Titouan')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (13, N'Sale')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (14, N'Khnifra')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (15, N'Stat')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (16, N'Guercif')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (17, N'Kalaa Seraghna')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (18, N'Dakhla')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (19, N'Ktama')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (20, N'Essaouira')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (21, N'Meknes')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (22, N'El jadida')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (23, N'Hosseima')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (24, N'Safi')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (25, N'Chefchaouen')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (26, N'Kenitra')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (27, N'Larache')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (28, N'Ifrane')
INSERT [dbo].[VILLE] ([IdVille], [LblVille]) VALUES (29, N'Temara')
SET IDENTITY_INSERT [dbo].[VILLE] OFF

INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En1598611', N'+212 614873027', N'Taoussi Ecommerce', 6)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En159863', N'+212 698423650', N'Slimani Agence Assurance', 1)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En3674212', N'+212 601375301', N'Asura', 6)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En959823', N'+212 726423620', N'Work Up', 2)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En9598413', N'+212 624911602', N'Dignerta', 6)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En119831', N'+212 674121606', N'Digital Factory', 13)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'En9598478', N'+212 669423660', N'Shopp Werfen', 15)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'Pa211972', N'+212 669491160', N'Shahinaz Sefriuou', 11)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'Pa2119725', N'+212 825423640', N'Nissrin Lhlou', 5)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'Pa2119778', N'+212 825423660', N'Brahim Hmdaoui', 20)
INSERT [dbo].[CLIENT] ([NumeroSerie], [NumeroTelephoneClient], [NomAgenceOuClient], [Id_Class#]) VALUES (N'Pa299925', N'+212 825423620', N'Ahmed Taoussi', 8)

INSERT [dbo].[ADMINN] ([id], [nom], [prenom], [email], [mdp]) VALUES (1, N'el mediouni', N'sohaib', N'sohaib@gmail.com', N'1234')
INSERT [dbo].[ADMINN] ([id], [nom], [prenom], [email], [mdp]) VALUES (2, N'chaiti', N'amine', N'amine@gmail.com', N'1234')
INSERT [dbo].[ADMINN] ([id], [nom], [prenom], [email], [mdp]) VALUES (3, N'safih', N'hicham', N'safih@gmail.com', N'1234')
INSERT [dbo].[ADMINN] ([id], [nom], [prenom], [email], [mdp]) VALUES (4, N'kati', N'issam', N'kati@gmail.com', N'1234')

INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (1, N'el mediouni', N'sohaib', N'sohaib@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (2, N'chaiti', N'amine', N'amine@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (3, N'saffih', N'hicham', N'safih@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (4, N'hajji', N'zakiri', N'zaki@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (5, N'imane', N'bb', N'imane@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (6, N'tilani', N'rabab', N'rabab@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (7, N'remdani', N'merym', N'remdani@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (8, N'zeroki', N'fati', N'fati@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (9, N'frikel', N'ahmed', N'ahmedd@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (10, N'maida', N'bilal', N'bilal@gmail.com', N'1234')
INSERT [dbo].[secretaire] ([id], [nom], [prenom], [email], [mdp]) VALUES (11, N'belehsen', N'mohemed', N'med@gmail.com', N'1234')

INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P1447', N'Vis pour PC', 5)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P1496', N'Montage', 300)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P1518', N'Boitier PC', 250)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P2217', N'Connectique interne', 763)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P2267', N'Isolationn phonique PC', 280)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P2421', N'Rack HDD interne', 1000)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P2765', N'Antivol PC', 150)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P2786', N'Ventilateur', 50)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P3341', N'Carte son', 700)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P4392', N'Accessoires divers', 100)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P4732', N'Barebone PC', 800)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P4933', N'Neon PC', 410)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P6255', N'Filtre anti poussiere', 70)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P8821', N'Rheobus', 277)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P9573', N'Disque dur', 304)
INSERT [dbo].[PIECE] ([RefPiece], [LblPiece], [Prix]) VALUES (N'P9687', N'Panneaux lateraux PC', 240)

insert into CODE_REPARATION values('B01', '-RAS'  )
insert into CODE_REPARATION values('B02','-RAS/Pb Résolu par utilisateur')
insert into CODE_REPARATION values('B03','-Reparation par Tel')
insert into CODE_REPARATION values('B04','-Ajustement de Nettoyage')
insert into CODE_REPARATION values('B05','-Remplacement Piéce')
insert into CODE_REPARATION values('B06','-Remplacement Module' )
insert into CODE_REPARATION values('B07','-Remplacement Unité')
insert into CODE_REPARATION values('B08','-Installation Nouveau Matériel  ' )
insert into CODE_REPARATION values('B09','-Modification Hard' )
insert into CODE_REPARATION values('B10','-Intervention Soft')
insert into CODE_REPARATION values('B11','-M.A.J Soft')
insert into CODE_REPARATION values('B12','-Reparation Vandalisme' )
insert into CODE_REPARATION values('B13','-Formation Utilisateur' )
insert into CODE_REPARATION values('B14','-Formation')
insert into CODE_REPARATION values('B15','-Maintenance preventive'  )
insert into CODE_REPARATION values('B16','-Rework  ')
insert into CODE_REPARATION values('B17','-Reparation + PM')
insert into CODE_REPARATION values('B18','-Autre')

SET IDENTITY_INSERT [dbo].[INGENIEUR] ON 
INSERT [dbo].[INGENIEUR] ([IdIngenieur], [noming], [prenom], [NumeroTelephoneIngenieur]) VALUES (1, N'Ahmed', N'Setiwi', N'+212 617479320')
INSERT [dbo].[INGENIEUR] ([IdIngenieur], [noming], [prenom], [NumeroTelephoneIngenieur]) VALUES (2, N'Nisrine', N'Fathi', N'+212 698479372')
INSERT [dbo].[INGENIEUR] ([IdIngenieur], [noming], [prenom], [NumeroTelephoneIngenieur]) VALUES (3, N'Amina', N'Seqqat', N'+212 614479333')
INSERT [dbo].[INGENIEUR] ([IdIngenieur], [noming], [prenom], [NumeroTelephoneIngenieur]) VALUES (4, N'Abdel Kader', N'Chennof', N'+212 630120479')
SET IDENTITY_INSERT [dbo].[INGENIEUR] OFF

insert into CODE_ERREUR values('B01','-Distributeur')
insert into CODE_ERREUR values('B02','-Depot')
insert into CODE_ERREUR values('B03','-Imprimante journal')
insert into CODE_ERREUR values('B04','-Imprimante Ticket')
insert into CODE_ERREUR values('B05','-Lecteur de carte')
insert into CODE_ERREUR values('B06','-Ecran' )
insert into CODE_ERREUR values('B07','-Clavier')
insert into CODE_ERREUR values('B08','-Facade' )
insert into CODE_ERREUR values('B09','-Neon' )
insert into CODE_ERREUR values('B10','-Combinaison')
insert into CODE_ERREUR values('B11','-Encrypteur' )
insert into CODE_ERREUR values('B12','-Processeur' )
insert into CODE_ERREUR values('B13','-PB Communication')
insert into CODE_ERREUR values('B14','-PB utilisateur'  )
insert into CODE_ERREUR values('B15','-Carte reseau')
insert into CODE_ERREUR values('B16','-Alimentation ')
insert into CODE_ERREUR values('B17','-Disque Dur')
insert into CODE_ERREUR values('B18','-Lecteur CD')
insert into CODE_ERREUR values('B19','-Lecteur DAT' )
insert into CODE_ERREUR values('B20','-Terminal PV')
insert into CODE_ERREUR values('B21','-Scanner de prix' )
insert into CODE_ERREUR values('B22','-Douchette' )
insert into CODE_ERREUR values('B23','-Afficheur')
insert into CODE_ERREUR values('B24','-Imprimante'  )
insert into CODE_ERREUR values('B25','-MP')
insert into CODE_ERREUR values('B26','-Installation')
insert into CODE_ERREUR values('B27','-Modification')
insert into CODE_ERREUR values('B28','-Passbook')
insert into CODE_ERREUR values('B29','-Tete Impression')
insert into CODE_ERREUR values('B30','-PB Consommabl ')
insert into CODE_ERREUR values('B31','-Encodeur')
insert into CODE_ERREUR values('B32','-Endosseur')
insert into CODE_ERREUR values('B33','-Hopper')
insert into CODE_ERREUR values('B34','-Poches')
insert into CODE_ERREUR values('B35','-Cassette')
insert into CODE_ERREUR values('B36','-Tirroir')
insert into CODE_ERREUR values('B37','-BNA')
insert into CODE_ERREUR values('B38','-Coin Dispenser')
insert into CODE_ERREUR values('B39','-Camera')
insert into CODE_ERREUR values('B40','-Onduleur')
insert into CODE_ERREUR values('B41','-Soft')
insert into CODE_ERREUR values('B42','-Lecteur de cheques')
insert into CODE_ERREUR values('B43','-Scanner de chaques')
insert into CODE_ERREUR values('B44','-BNR')
insert into CODE_ERREUR values('B45','-Recycleur')
insert into CODE_ERREUR values('B46','-Monnayeur')
insert into CODE_ERREUR values('B47','-TPE')
insert into CODE_ERREUR values('B48','-Formation')
insert into CODE_ERREUR values('B49','-Assistance')
insert into CODE_ERREUR values('B50','-Autre')


/*
CODE_REPARATION
[INGENIEUR]
[VILLE]
[CLIENT]
[PIECE]
[admin]
[secretaire]
*/