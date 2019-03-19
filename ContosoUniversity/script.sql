CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Instructor" (
    "ID" INTEGER NOT NULL CONSTRAINT "PK_Instructor" PRIMARY KEY AUTOINCREMENT,
    "LastName" TEXT NOT NULL,
    "FirstName" TEXT NOT NULL,
    "HireDate" TEXT NOT NULL
);

CREATE TABLE "Student" (
    "ID" INTEGER NOT NULL CONSTRAINT "PK_Student" PRIMARY KEY AUTOINCREMENT,
    "LastName" TEXT NOT NULL,
    "FirstName" TEXT NOT NULL,
    "EnrollmentDate" TEXT NOT NULL
);

CREATE TABLE "Department" (
    "DepartmentID" INTEGER NOT NULL CONSTRAINT "PK_Department" PRIMARY KEY AUTOINCREMENT,
    "Name" TEXT NULL,
    "Budget" money NOT NULL,
    "StartDate" TEXT NOT NULL,
    "InstructorID" INTEGER NULL,
    CONSTRAINT "FK_Department_Instructor_InstructorID" FOREIGN KEY ("InstructorID") REFERENCES "Instructor" ("ID") ON DELETE RESTRICT
);

CREATE TABLE "OfficeAssignment" (
    "InstructorID" INTEGER NOT NULL CONSTRAINT "PK_OfficeAssignment" PRIMARY KEY,
    "Location" TEXT NULL,
    CONSTRAINT "FK_OfficeAssignment_Instructor_InstructorID" FOREIGN KEY ("InstructorID") REFERENCES "Instructor" ("ID") ON DELETE CASCADE
);

CREATE TABLE "Course" (
    "CourseID" INTEGER NOT NULL CONSTRAINT "PK_Course" PRIMARY KEY,
    "Title" TEXT NULL,
    "Credits" INTEGER NOT NULL,
    "DepartmentID" INTEGER NOT NULL,
    CONSTRAINT "FK_Course_Department_DepartmentID" FOREIGN KEY ("DepartmentID") REFERENCES "Department" ("DepartmentID") ON DELETE CASCADE
);

CREATE TABLE "CourseAssignment" (
    "InstructorID" INTEGER NOT NULL,
    "CourseID" INTEGER NOT NULL,
    CONSTRAINT "PK_CourseAssignment" PRIMARY KEY ("CourseID", "InstructorID"),
    CONSTRAINT "FK_CourseAssignment_Course_CourseID" FOREIGN KEY ("CourseID") REFERENCES "Course" ("CourseID") ON DELETE CASCADE,
    CONSTRAINT "FK_CourseAssignment_Instructor_InstructorID" FOREIGN KEY ("InstructorID") REFERENCES "Instructor" ("ID") ON DELETE CASCADE
);

CREATE TABLE "Enrollment" (
    "EnrollmentID" INTEGER NOT NULL CONSTRAINT "PK_Enrollment" PRIMARY KEY AUTOINCREMENT,
    "CourseID" INTEGER NOT NULL,
    "StudentID" INTEGER NOT NULL,
    "Grade" INTEGER NULL,
    CONSTRAINT "FK_Enrollment_Course_CourseID" FOREIGN KEY ("CourseID") REFERENCES "Course" ("CourseID") ON DELETE CASCADE,
    CONSTRAINT "FK_Enrollment_Student_StudentID" FOREIGN KEY ("StudentID") REFERENCES "Student" ("ID") ON DELETE CASCADE
);

CREATE INDEX "IX_Course_DepartmentID" ON "Course" ("DepartmentID");

CREATE INDEX "IX_CourseAssignment_InstructorID" ON "CourseAssignment" ("InstructorID");

CREATE INDEX "IX_Department_InstructorID" ON "Department" ("InstructorID");

CREATE INDEX "IX_Enrollment_CourseID" ON "Enrollment" ("CourseID");

CREATE INDEX "IX_Enrollment_StudentID" ON "Enrollment" ("StudentID");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20190319175836_ComplexDataModel', '2.2.3-servicing-35854');

