-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 06, 2026 at 11:52 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kasirminimarket`
--

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--

CREATE TABLE `kategori` (
  `id_kategori` varchar(10) NOT NULL,
  `nama_kategori` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kategori`
--

INSERT INTO `kategori` (`id_kategori`, `nama_kategori`) VALUES
('1', 'umum');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `id_pembelian` varchar(12) NOT NULL,
  `id_supplier` varchar(10) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `total` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `pembelian_detail`
--

CREATE TABLE `pembelian_detail` (
  `id_pembelian` varchar(12) NOT NULL,
  `id_produk` varchar(10) NOT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `harga_beli` decimal(12,2) DEFAULT NULL,
  `subtotal` decimal(12,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE `produk` (
  `id_produk` varchar(10) NOT NULL,
  `nama_produk` varchar(100) DEFAULT NULL,
  `id_kategori` varchar(10) DEFAULT NULL,
  `harga_jual` decimal(12,2) DEFAULT NULL,
  `harga_beli` decimal(12,2) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  `satuan` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `produk`
--

INSERT INTO `produk` (`id_produk`, `nama_produk`, `id_kategori`, `harga_jual`, `harga_beli`, `stok`, `satuan`) VALUES
('1', 'kopi', '1', 12000.00, 10000.00, 41, 'Bungkus'),
('2', 'cola', '1', 6000.00, 5000.00, 3, 'Botol'),
('3', 'air putih', '1', 5000.00, 3000.00, 98, 'Botol'),
('4', 'ice cream', '1', 12000.00, 10000.00, 45, 'Bungkus'),
('5', 'susu', '1', 11000.00, 10000.00, 100, 'Botol');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` varchar(10) NOT NULL,
  `nama_supplier` varchar(100) DEFAULT NULL,
  `telepon` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_detail`
--

CREATE TABLE `transaksi_detail` (
  `no_faktur` varchar(20) DEFAULT NULL,
  `kode_barang` varchar(50) DEFAULT NULL,
  `nama_barang` varchar(100) DEFAULT NULL,
  `harga_jual` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `subtotal` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi_detail`
--

INSERT INTO `transaksi_detail` (`no_faktur`, `kode_barang`, `nama_barang`, `harga_jual`, `jumlah`, `subtotal`) VALUES
('TRX251217001', '1', 'kopi', 12000, 1, 12000),
('TRX251217002', '1', 'kopi', 12000, 1, 12000),
('TRX251219001', '4', 'ice cream', 12000, 5, 60000),
('TRX251219001', '1', 'kopi', 12000, 1, 12000),
('TRX251219001', '2', 'cola', 6000, 1, 6000),
('TRX251219001', '3', 'air putih', 5000, 1, 5000),
('TRX251220001', '1', 'kopi', 12000, 3, 36000),
('TRX251220002', '2', 'cola', 6000, 1, 6000),
('TRX251227001', '1', 'kopi', 12000, 1, 12000),
('TRX251227001', '2', 'cola', 6000, 4, 24000),
('TRX260105001', '1', 'kopi', 12000, 1, 12000),
('TRX260105002', '1', 'kopi', 12000, 1, 12000),
('TRX260105002', '2', 'cola', 6000, 1, 6000),
('TRX260105002', '3', 'air putih', 5000, 1, 5000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_header`
--

CREATE TABLE `transaksi_header` (
  `no_faktur` varchar(20) NOT NULL,
  `tgl_transaksi` date DEFAULT NULL,
  `jam_transaksi` time DEFAULT NULL,
  `total_belanja` int(11) DEFAULT NULL,
  `bayar` int(11) DEFAULT NULL,
  `kembali` int(11) DEFAULT NULL,
  `kode_user` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi_header`
--

INSERT INTO `transaksi_header` (`no_faktur`, `tgl_transaksi`, `jam_transaksi`, `total_belanja`, `bayar`, `kembali`, `kode_user`) VALUES
('TRX251217001', '2025-12-17', '21:25:10', 12000, 20000, 8000, 'Dicky Eksa'),
('TRX251217002', '2025-12-17', '21:31:27', 12000, 20000, 8000, 'Dicky Eksa'),
('TRX251219001', '2025-12-19', '18:18:51', 83000, 100000, 17000, 'Dicky Eksa'),
('TRX251220001', '2025-12-20', '18:56:53', 36000, 50000, 26000, 'Dicky Eksa'),
('TRX251220002', '2025-12-20', '19:03:56', 6000, 10000, 4000, 'Dicky Eksa'),
('TRX251227001', '2025-12-27', '19:32:16', 36000, 36000, 0, 'Dicky Eksa'),
('TRX260105001', '2026-01-05', '17:39:50', 12000, 50000, 38000, 'user'),
('TRX260105002', '2026-01-05', '18:18:19', 23000, 50000, 27000, 'user');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` varchar(10) NOT NULL,
  `nama_user` varchar(50) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `nama_user`, `username`, `password`, `role`) VALUES
('user01', 'Dicky Eksa', 'dickyeksa', '675d3b3bdf9eb580a12392849e6b82e4', 'admin'),
('user02', 'Dicky Eksa', 'dickykasir', '675d3b3bdf9eb580a12392849e6b82e4', 'kasir'),
('user03', 'user', 'admin', '21232f297a57a5a743894a0e4a801fc3', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id_pembelian`),
  ADD KEY `fk_beli_supplier` (`id_supplier`);

--
-- Indexes for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD PRIMARY KEY (`id_pembelian`,`id_produk`),
  ADD KEY `id_produk` (`id_produk`);

--
-- Indexes for table `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`id_produk`),
  ADD KEY `fk_produk_kategori` (`id_kategori`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `transaksi_header`
--
ALTER TABLE `transaksi_header`
  ADD PRIMARY KEY (`no_faktur`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD CONSTRAINT `fk_beli_supplier` FOREIGN KEY (`id_supplier`) REFERENCES `supplier` (`id_supplier`) ON UPDATE CASCADE;

--
-- Constraints for table `pembelian_detail`
--
ALTER TABLE `pembelian_detail`
  ADD CONSTRAINT `pembelian_detail_ibfk_1` FOREIGN KEY (`id_pembelian`) REFERENCES `pembelian` (`id_pembelian`) ON DELETE CASCADE,
  ADD CONSTRAINT `pembelian_detail_ibfk_2` FOREIGN KEY (`id_produk`) REFERENCES `produk` (`id_produk`) ON UPDATE CASCADE;

--
-- Constraints for table `produk`
--
ALTER TABLE `produk`
  ADD CONSTRAINT `fk_produk_kategori` FOREIGN KEY (`id_kategori`) REFERENCES `kategori` (`id_kategori`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
