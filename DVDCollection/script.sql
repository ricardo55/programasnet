CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Actor" (
    "ActorID" INTEGER NOT NULL CONSTRAINT "PK_Actor" PRIMARY KEY AUTOINCREMENT,
    "ActorFullName" TEXT NULL,
    "ActorNotes" TEXT NULL
);

CREATE TABLE "Certificate" (
    "CertificateID" INTEGER NOT NULL CONSTRAINT "PK_Certificate" PRIMARY KEY AUTOINCREMENT,
    "CertificateName" TEXT NULL
);

CREATE TABLE "Genre" (
    "GenreID" INTEGER NOT NULL CONSTRAINT "PK_Genre" PRIMARY KEY AUTOINCREMENT,
    "GenreName" TEXT NULL
);

CREATE TABLE "Producer" (
    "ProducerID" INTEGER NOT NULL CONSTRAINT "PK_Producer" PRIMARY KEY AUTOINCREMENT,
    "ProducerName" TEXT NULL,
    "ProducerEmail" TEXT NULL,
    "ProducerWeb" TEXT NULL
);

CREATE TABLE "Role" (
    "RoleID" INTEGER NOT NULL CONSTRAINT "PK_Role" PRIMARY KEY AUTOINCREMENT,
    "RolName" TEXT NULL
);

CREATE TABLE "FilmTitle" (
    "FilmTitleID" INTEGER NOT NULL CONSTRAINT "PK_FilmTitle" PRIMARY KEY AUTOINCREMENT,
    "GenreID" INTEGER NOT NULL,
    "CertificateID" INTEGER NOT NULL,
    "FilmName" TEXT NULL,
    "FilmStory" TEXT NULL,
    "FilmReleaseDate" TEXT NOT NULL,
    "FilmDuration" INTEGER NOT NULL,
    "FilmAdditionalInfo" TEXT NULL,
    CONSTRAINT "FK_FilmTitle_Certificate_CertificateID" FOREIGN KEY ("CertificateID") REFERENCES "Certificate" ("CertificateID") ON DELETE CASCADE,
    CONSTRAINT "FK_FilmTitle_Genre_GenreID" FOREIGN KEY ("GenreID") REFERENCES "Genre" ("GenreID") ON DELETE CASCADE
);

CREATE TABLE "FilmActorRole" (
    "FilmTitleID" INTEGER NOT NULL,
    "ActorID" INTEGER NOT NULL,
    "RoleID" INTEGER NOT NULL,
    "CharacterName" TEXT NOT NULL,
    "CharacterDesc" TEXT NULL,
    CONSTRAINT "PK_FilmActorRole" PRIMARY KEY ("FilmTitleID", "ActorID", "RoleID", "CharacterName"),
    CONSTRAINT "FK_FilmActorRole_Actor_ActorID" FOREIGN KEY ("ActorID") REFERENCES "Actor" ("ActorID") ON DELETE CASCADE,
    CONSTRAINT "FK_FilmActorRole_FilmTitle_FilmTitleID" FOREIGN KEY ("FilmTitleID") REFERENCES "FilmTitle" ("FilmTitleID") ON DELETE CASCADE,
    CONSTRAINT "FK_FilmActorRole_Role_RoleID" FOREIGN KEY ("RoleID") REFERENCES "Role" ("RoleID") ON DELETE CASCADE
);

CREATE TABLE "FilmTitleProducer" (
    "FilmTitleID" INTEGER NOT NULL,
    "ProducerID" INTEGER NOT NULL,
    CONSTRAINT "PK_FilmTitleProducer" PRIMARY KEY ("ProducerID", "FilmTitleID"),
    CONSTRAINT "FK_FilmTitleProducer_FilmTitle_FilmTitleID" FOREIGN KEY ("FilmTitleID") REFERENCES "FilmTitle" ("FilmTitleID") ON DELETE CASCADE,
    CONSTRAINT "FK_FilmTitleProducer_Producer_ProducerID" FOREIGN KEY ("ProducerID") REFERENCES "Producer" ("ProducerID") ON DELETE CASCADE
);

CREATE INDEX "IX_FilmActorRole_ActorID" ON "FilmActorRole" ("ActorID");

CREATE INDEX "IX_FilmActorRole_RoleID" ON "FilmActorRole" ("RoleID");

CREATE INDEX "IX_FilmTitle_CertificateID" ON "FilmTitle" ("CertificateID");

CREATE INDEX "IX_FilmTitle_GenreID" ON "FilmTitle" ("GenreID");

CREATE INDEX "IX_FilmTitleProducer_FilmTitleID" ON "FilmTitleProducer" ("FilmTitleID");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190324174245_ComplexDataModel', '2.2.3-servicing-35854');

