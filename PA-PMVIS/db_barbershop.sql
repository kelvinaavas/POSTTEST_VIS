-- ============================================================
-- DATABASE: db_barbershop
-- Project  : PA-PMVIS
-- ============================================================

CREATE DATABASE IF NOT EXISTS db_barbershop
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_general_ci;

USE db_barbershop;

-- ============================================================
-- TABEL BARBER
-- ============================================================
CREATE TABLE IF NOT EXISTS tbbarber (
    idBarber    INT AUTO_INCREMENT PRIMARY KEY,
    namaBarber  VARCHAR(100) NOT NULL
) ENGINE=InnoDB;

INSERT INTO tbbarber (namaBarber) VALUES
    ('Aldi'),
    ('Bram'),
    ('Cahyo'),
    ('Dani'),
    ('Eko');

-- ============================================================
-- TABEL PELAYANAN
-- ============================================================
CREATE TABLE IF NOT EXISTS tbpelayanan (
    idPelayanan     INT AUTO_INCREMENT PRIMARY KEY,
    namaPelayanan   VARCHAR(100) NOT NULL,
    harga           INT          NOT NULL DEFAULT 0
) ENGINE=InnoDB;

INSERT INTO tbpelayanan (namaPelayanan, harga) VALUES
    ('Cukur Rambut',        35000),
    ('Cukur + Cuci Rambut', 50000),
    ('Cukur + Creambath',   75000),
    ('Trim Jenggot',        25000),
    ('Perawatan Rambut',    60000);

-- ============================================================
-- TABEL ANTRIAN
-- ============================================================
CREATE TABLE IF NOT EXISTS tbantrian (
    idAntrian       INT AUTO_INCREMENT PRIMARY KEY,
    nomorAntrian    VARCHAR(10)  NOT NULL,
    namaCustomer    VARCHAR(100) NOT NULL,
    idPelayanan     INT          NOT NULL,
    idBarber        INT          NOT NULL,
    status          VARCHAR(20)  NOT NULL DEFAULT 'Menunggu',
    pembayaran      INT          NOT NULL DEFAULT 0,
    FOREIGN KEY (idPelayanan) REFERENCES tbpelayanan(idPelayanan),
    FOREIGN KEY (idBarber)    REFERENCES tbbarber(idBarber)
) ENGINE=InnoDB;

-- Contoh data antrian
INSERT INTO tbantrian (nomorAntrian, namaCustomer, idPelayanan, idBarber, status, pembayaran) VALUES
    ('A01', 'Budi Santoso',   1, 1, 'Selesai',   35000),
    ('A02', 'Reza Pratama',   2, 3, 'Proses',        0),
    ('A03', 'Fajar Nugroho',  4, 2, 'Menunggu',      0),
    ('A04', 'Hendra Wijaya',  3, 5, 'Menunggu',      0),
    ('A05', 'Gilang Saputra', 5, 4, 'Menunggu',      0);
