USE [bastianviviermerle]
GO
/****** Object:  StoredProcedure [dbo].[lp_RetournerMateriel]    Script Date: 04/06/2025 13:56:01 ******/
DROP PROCEDURE [dbo].[lp_RetournerMateriel]
GO
/****** Object:  StoredProcedure [dbo].[lp_ListerPrets]    Script Date: 04/06/2025 13:56:01 ******/
DROP PROCEDURE [dbo].[lp_ListerPrets]
GO
/****** Object:  StoredProcedure [dbo].[lp_GetStockMateriel]    Script Date: 04/06/2025 13:56:01 ******/
DROP PROCEDURE [dbo].[lp_GetStockMateriel]
GO
/****** Object:  StoredProcedure [dbo].[lp_CreerPretMateriel]    Script Date: 04/06/2025 13:56:01 ******/
DROP PROCEDURE [dbo].[lp_CreerPretMateriel]
GO
/****** Object:  StoredProcedure [dbo].[lp_AuthentifierMembre]    Script Date: 04/06/2025 13:56:01 ******/
DROP PROCEDURE [dbo].[lp_AuthentifierMembre]
GO
/****** Object:  StoredProcedure [dbo].[lp_AjouterMateriel]    Script Date: 04/06/2025 13:56:01 ******/
DROP PROCEDURE [dbo].[lp_AjouterMateriel]
GO
ALTER TABLE [dbo].[LP_PretMateriel] DROP CONSTRAINT [FK__LP_PretMa__idMem__20E1DCB5]
GO
ALTER TABLE [dbo].[LP_Monopalme] DROP CONSTRAINT [FK__LP_Monopa__idMat__2A6B46EF]
GO
ALTER TABLE [dbo].[LP_Liaison] DROP CONSTRAINT [FK__LP_Liaiso__idPre__24B26D99]
GO
ALTER TABLE [dbo].[LP_Liaison] DROP CONSTRAINT [FK__LP_Liaiso__idMat__23BE4960]
GO
ALTER TABLE [dbo].[LP_Combinaison] DROP CONSTRAINT [FK__LP_Combin__idMat__278EDA44]
GO
/****** Object:  Table [dbo].[LP_StockMateriel]    Script Date: 04/06/2025 13:56:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LP_StockMateriel]') AND type in (N'U'))
DROP TABLE [dbo].[LP_StockMateriel]
GO
/****** Object:  Table [dbo].[LP_PretMateriel]    Script Date: 04/06/2025 13:56:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LP_PretMateriel]') AND type in (N'U'))
DROP TABLE [dbo].[LP_PretMateriel]
GO
/****** Object:  Table [dbo].[LP_Monopalme]    Script Date: 04/06/2025 13:56:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LP_Monopalme]') AND type in (N'U'))
DROP TABLE [dbo].[LP_Monopalme]
GO
/****** Object:  Table [dbo].[LP_Membre]    Script Date: 04/06/2025 13:56:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LP_Membre]') AND type in (N'U'))
DROP TABLE [dbo].[LP_Membre]
GO
/****** Object:  Table [dbo].[LP_Liaison]    Script Date: 04/06/2025 13:56:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LP_Liaison]') AND type in (N'U'))
DROP TABLE [dbo].[LP_Liaison]
GO
/****** Object:  Table [dbo].[LP_Combinaison]    Script Date: 04/06/2025 13:56:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LP_Combinaison]') AND type in (N'U'))
DROP TABLE [dbo].[LP_Combinaison]
GO
/****** Object:  Table [dbo].[LP_Combinaison]    Script Date: 04/06/2025 13:56:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LP_Combinaison](
	[idMateriel] [int] NOT NULL,
	[taille] [varchar](10) NULL,
	[epaisseur] [decimal](4, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMateriel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LP_Liaison]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LP_Liaison](
	[idMateriel] [int] NOT NULL,
	[idPret] [int] NOT NULL,
	[etatPret] [varchar](50) NULL,
	[etatRetour] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMateriel] ASC,
	[idPret] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LP_Membre]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LP_Membre](
	[idMembre] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varbinary](max) NOT NULL,
	[prenom] [varbinary](max) NOT NULL,
	[email] [varbinary](max) NOT NULL,
	[tel] [varbinary](max) NULL,
	[login] [varbinary](max) NOT NULL,
	[password] [char](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMembre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LP_Monopalme]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LP_Monopalme](
	[idMateriel] [int] NOT NULL,
	[pointure] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMateriel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LP_PretMateriel]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LP_PretMateriel](
	[idPret] [int] IDENTITY(1,1) NOT NULL,
	[idMembre] [int] NULL,
	[datePret] [date] NULL,
	[dateRetour] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPret] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LP_StockMateriel]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LP_StockMateriel](
	[idMateriel] [int] IDENTITY(1,1) NOT NULL,
	[libelle] [varchar](100) NULL,
	[marque] [varchar](50) NULL,
	[QteTotale] [int] NULL,
	[QteDisponible] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idMateriel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LP_Liaison] ([idMateriel], [idPret], [etatPret], [etatRetour]) VALUES (1, 2, N'Neuf', N'neuf')
GO
SET IDENTITY_INSERT [dbo].[LP_Membre] ON 

INSERT [dbo].[LP_Membre] ([idMembre], [nom], [prenom], [email], [tel], [login], [password]) VALUES (2, 0x00EB60DB6DA60C4ABF201FC312C88AEB02000000423028EA9ADD71BE6EE38FEEBB3F97A48B7AC05A4F2BE6B7F5E9BE61ED50848C, 0x00EB60DB6DA60C4ABF201FC312C88AEB020000007E34B08170D68E0FDEDA49DB2463CABD0DAF800A2A120E83C4DB1D31DA2A6095, 0x00EB60DB6DA60C4ABF201FC312C88AEB020000000EC84A7327F6DCE3C7BFE462730E3831F2824E683AC8834ABB35E66C4CB8578E5BD8AC2B7D3FC151DDE9048AD395C217, 0x00EB60DB6DA60C4ABF201FC312C88AEB0200000097BF7D89FAADDB99588FF13E671F67B98AA75D321A2AC62DD9BB629E9E36535672FF9CCC035C0D274F669145D537D7C1, 0x00EB60DB6DA60C4ABF201FC312C88AEB020000002CCB9879198AEC546572050EB76E103F774763E6A79DF5D12B94EF41FF45F2E7, N'7629153C430B33ACA4D57949D6A2C289BAFF735A1A0BD3A2F7E1170ECA77B30CF22F2EA00149A230DB9EA9E79A1B66399C7EB31EB72F85030DBDCA811EA5AF51')
SET IDENTITY_INSERT [dbo].[LP_Membre] OFF
GO
INSERT [dbo].[LP_Monopalme] ([idMateriel], [pointure]) VALUES (1, N'43')
GO
SET IDENTITY_INSERT [dbo].[LP_PretMateriel] ON 

INSERT [dbo].[LP_PretMateriel] ([idPret], [idMembre], [datePret], [dateRetour]) VALUES (2, 2, CAST(N'2025-06-02' AS Date), CAST(N'2025-06-02' AS Date))
SET IDENTITY_INSERT [dbo].[LP_PretMateriel] OFF
GO
SET IDENTITY_INSERT [dbo].[LP_StockMateriel] ON 

INSERT [dbo].[LP_StockMateriel] ([idMateriel], [libelle], [marque], [QteTotale], [QteDisponible]) VALUES (1, N'Monopalme', N'addidas', 50, 49)
SET IDENTITY_INSERT [dbo].[LP_StockMateriel] OFF
GO
ALTER TABLE [dbo].[LP_Combinaison]  WITH CHECK ADD FOREIGN KEY([idMateriel])
REFERENCES [dbo].[LP_StockMateriel] ([idMateriel])
GO
ALTER TABLE [dbo].[LP_Liaison]  WITH CHECK ADD FOREIGN KEY([idMateriel])
REFERENCES [dbo].[LP_StockMateriel] ([idMateriel])
GO
ALTER TABLE [dbo].[LP_Liaison]  WITH CHECK ADD FOREIGN KEY([idPret])
REFERENCES [dbo].[LP_PretMateriel] ([idPret])
GO
ALTER TABLE [dbo].[LP_Monopalme]  WITH CHECK ADD FOREIGN KEY([idMateriel])
REFERENCES [dbo].[LP_StockMateriel] ([idMateriel])
GO
ALTER TABLE [dbo].[LP_PretMateriel]  WITH CHECK ADD FOREIGN KEY([idMembre])
REFERENCES [dbo].[LP_Membre] ([idMembre])
GO
/****** Object:  StoredProcedure [dbo].[lp_AjouterMateriel]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lp_AjouterMateriel]
    @libelle VARCHAR(100),
    @marque VARCHAR(100),
    @QteTotale INT,
    @QteDisponible INT,
    @typeMateriel VARCHAR(20), -- 'Monopalme' ou 'Combinaison'
    @pointure INT = NULL,       -- pour Monopalme
    @taille VARCHAR(50) = NULL, -- pour Combinaison
    @epaisseur FLOAT = NULL     -- pour Combinaison
AS
BEGIN
    SET NOCOUNT ON;

    -- Étape 1 : Insérer dans LP_StockMateriel
    INSERT INTO LP_StockMateriel (libelle, marque, QteTotale, QteDisponible)
    VALUES (@libelle, @marque, @QteTotale, @QteDisponible);

    DECLARE @idMateriel INT = SCOPE_IDENTITY();

    -- Étape 2 : Insérer selon le type
    IF @typeMateriel = 'Monopalme'
    BEGIN
        INSERT INTO LP_Monopalme (idMateriel, pointure)
        VALUES (@idMateriel, @pointure);
    END
    ELSE IF @typeMateriel = 'Combinaison'
    BEGIN
        INSERT INTO LP_Combinaison (idMateriel, taille, epaisseur)
        VALUES (@idMateriel, @taille, @epaisseur);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[lp_AuthentifierMembre]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lp_AuthentifierMembre]
    @login VARCHAR(50),
    @password CHAR(128)  -- SHA512 en hex : 128 caractères
AS
BEGIN
    OPEN SYMMETRIC KEY CleMembre DECRYPTION BY CERTIFICATE CertificatMembre;

    SELECT 
        idMembre, 
        CONVERT(VARCHAR(100), DECRYPTBYKEY(nom)) AS nom,
        CONVERT(VARCHAR(100), DECRYPTBYKEY(prenom)) AS prenom
    FROM LP_Membre
    WHERE 
        CONVERT(VARCHAR(100), DECRYPTBYKEY(login)) = @login
        AND password = @password;

    CLOSE SYMMETRIC KEY CleMembre;
END
GO
/****** Object:  StoredProcedure [dbo].[lp_CreerPretMateriel]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lp_CreerPretMateriel]
    @idMembre INT,
    @idMateriel INT,
    @datePret DATE,
    @dateRetour DATE,
    @etatPret VARCHAR(100),
    @etatRetour VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Étape 1 : Insérer dans LP_PretMateriel
    INSERT INTO LP_PretMateriel (idMembre, datePret, dateRetour)
    VALUES (@idMembre, @datePret, @dateRetour);

    DECLARE @idPret INT = SCOPE_IDENTITY();

    -- Étape 2 : Insérer dans LP_Liaison
    INSERT INTO LP_Liaison (idPret, idMateriel, etatPret, etatRetour)
    VALUES (@idPret, @idMateriel, @etatPret, @etatRetour);

    -- Étape 3 : Mettre à jour la quantité dispo
    UPDATE LP_StockMateriel
    SET QteDisponible = QteDisponible - 1
    WHERE idMateriel = @idMateriel AND QteDisponible > 0;
END
GO
/****** Object:  StoredProcedure [dbo].[lp_GetStockMateriel]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lp_GetStockMateriel]
AS
BEGIN
    SELECT 
        SM.idMateriel,
        SM.libelle,
        SM.marque,
        SM.QteTotale,
        SM.QteDisponible,
        C.taille,
        C.epaisseur,
        M.pointure
    FROM LP_StockMateriel SM
    LEFT JOIN LP_Combinaison C ON SM.idMateriel = C.idMateriel
    LEFT JOIN LP_Monopalme M ON SM.idMateriel = M.idMateriel
END
GO
/****** Object:  StoredProcedure [dbo].[lp_ListerPrets]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lp_ListerPrets]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        P.idPret,
        P.idMembre,
        L.idMateriel,
        P.datePret,
        P.dateRetour,
        L.etatPret,
        L.etatRetour
    FROM LP_PretMateriel P
    JOIN LP_Liaison L ON P.idPret = L.idPret
    ORDER BY P.datePret DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[lp_RetournerMateriel]    Script Date: 04/06/2025 13:56:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lp_RetournerMateriel]
    @idPret INT,
    @etatRetour VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @idMateriel INT;

    -- 1️⃣ Récupérer l’ID du matériel
    SELECT @idMateriel = idMateriel FROM LP_Liaison WHERE idPret = @idPret;

    -- 2️⃣ Mettre à jour l'état de retour
    UPDATE LP_Liaison
    SET etatRetour = @etatRetour
    WHERE idPret = @idPret;

    -- 3️⃣ Réincrémenter le stock
    UPDATE LP_StockMateriel
    SET QteDisponible = QteDisponible + 1
    WHERE idMateriel = @idMateriel;
END
GO
