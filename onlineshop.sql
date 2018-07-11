-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 11, 2018 at 05:00 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `onlineshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `barangdagangan`
--

CREATE TABLE `barangdagangan` (
  `id_barang` varchar(45) NOT NULL,
  `id_penjual` varchar(45) NOT NULL,
  `image` varchar(100) DEFAULT NULL,
  `nama_barang` varchar(45) DEFAULT NULL,
  `deskripsi` longtext,
  `harga` bigint(20) DEFAULT NULL,
  `tanggal_upload` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `deleted` int(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `barangdagangan`
--

INSERT INTO `barangdagangan` (`id_barang`, `id_penjual`, `image`, `nama_barang`, `deskripsi`, `harga`, `tanggal_upload`, `deleted`) VALUES
('ITEM0000000001', 'SLR0000000001', 'D:\\PROGRAMING\\SERVER_FOTO\\Ideapad_B460_L_1.jpg', 'Lenovo B460', 'Intel Graphics Media Accelerator (GMA) 4500MHD: Onboard (shared Memory) GPU built in the GM45, GE45 and GS45 chipset (Montevina). \n\nBecause of two more shaders and a higher core clock, much faster than the old GMA X3100. Still not advisable for gamers (DirectX 10 games not playable or only with very low settings). \n\nThe integrated video processor is able to help decode HD videos (AVC/VC-2/MPEG2) , e.g., for a fluent Blu-Ray playback with slow CPUs. \n\nOnly some 3D games with very low demands are playable with these cards. » Further information can be found in our Comparison of Mobile Graphics Cards and the corresponding Benchmark List.', 2599999, '2018-07-09 09:33:55', 0),
('ITEM0000000002', 'SLR0000000001', 'D:\\PROGRAMING\\SERVER_FOTO\\tas.jpg', 'Tas Ransel', 'sds dsdsd sds d sd sd sd sd sd s ds ds d sd sdsdsdsds d sd sd sdsdsds sdsdsd sdsdsdsd dsd sdsd s sds d   sds', 120000, '2018-07-05 09:00:09', 0),
('ITEM0000000003', 'SLR0000000001', 'D:\\PROGRAMING\\SERVER_FOTO\\Ideapad_B460_L_1.jpg', 'Lenovo B460 New', 'Intel Graphics Media Accelerator (GMA) 4500MHD: Onboard (shared Memory) GPU built in the GM45, GE45 and GS45 chipset (Montevina). Because of two more shaders and a higher core clock, much faster than the old GMA X3100. Still not advisable for gamers (DirectX 10 games not playable or only with very low settings). The integrated video processor is able to help decode HD videos (AVC/VC-2/MPEG2) , e.g., for a fluent Blu-Ray playback with slow CPUs. Only some 3D games with very low demands are playable with these cards. » Further information can be found in our Comparison of Mobile Graphics Cards and the corresponding Benchmark List.', 2100000, '2018-07-05 08:14:24', 0),
('ITEM0000000004', 'SLR0000000002', 'D:\\PROGRAMING\\SERVER_FOTO\\tas.jpg', 'Tas Punggung', 'sds dsdsd sds d sd sd sd sd sd s ds ds d sd sdsdsdsds d sd sd sdsdsds sdsdsd sdsdsdsd dsd sdsd s sds d   sds', 52000, '2018-07-05 09:00:09', 0),
('ITEM0000000005', 'SLR0000000001', 'D:\\ICON\\bank.png', 'UANG MAINAN', 'UANG MAINAN', 1000000, '2018-07-09 09:17:30', 0),
('ITEM0000000006', 'SLR0000000001', 'D:\\PROGRAMING\\SERVER_FOTO\\Ideapad_B460_L_1.jpg', 'Lenovo B460', 'Intel Graphics Media Accelerator (GMA) 4500MHD: Onboard (shared Memory) GPU built in the GM45, GE45 and GS45 chipset (Montevina). \n\nBecause of two more shaders and a higher core clock, much faster than the old GMA X3100. Still not advisable for gamers (DirectX 10 games not playable or only with very low settings). \n\nThe integrated video processor is able to help decode HD videos (AVC/VC-2/MPEG2) , e.g., for a fluent Blu-Ray playback with slow CPUs. \n\nOnly some 3D games with very low demands are playable with these cards. » Further information can be found in our Comparison of Mobile Graphics Cards and the corresponding Benchmark List.', 2500000, '2018-07-09 09:27:07', 1),
('ITEM0000000007', 'SLR0000000001', 'D:\\PROGRAMING\\SERVER_FOTO\\Ideapad_B460_L_1.jpg', 'Lenovo B460', 'Intel Graphics Media Accelerator (GMA) 4500MHD: Onboard (shared Memory) GPU built in the GM45, GE45 and GS45 chipset (Montevina). \n\nBecause of two more shaders and a higher core clock, much faster than the old GMA X3100. Still not advisable for gamers (DirectX 10 games not playable or only with very low settings). \n\nThe integrated video processor is able to help decode HD videos (AVC/VC-2/MPEG2) , e.g., for a fluent Blu-Ray playback with slow CPUs. \n\nOnly some 3D games with very low demands are playable with these cards. » Further information can be found in our Comparison of Mobile Graphics Cards and the corresponding Benchmark List.', 2500000, '2018-07-09 09:27:09', 1),
('ITEM0000000008', 'SLR0000000001', 'D:\\PROGRAMING\\SERVER_FOTO\\Ideapad_B460_L_1.jpg', 'Lenovo B460', 'Intel Graphics Media Accelerator (GMA) 4500MHD: Onboard (shared Memory) GPU built in the GM45, GE45 and GS45 chipset (Montevina). \n\nBecause of two more shaders and a higher core clock, much faster than the old GMA X3100. Still not advisable for gamers (DirectX 10 games not playable or only with very low settings). \n\nThe integrated video processor is able to help decode HD videos (AVC/VC-2/MPEG2) , e.g., for a fluent Blu-Ray playback with slow CPUs. \n\nOnly some 3D games with very low demands are playable with these cards. » Further information can be found in our Comparison of Mobile Graphics Cards and the corresponding Benchmark List.', 2500000, '2018-07-09 09:27:10', 1),
('ITEM0000000009', 'SLR0000000001', 'D:\\ICON\\226777.png', 'KOPI VIRTUAL', 'Kopi Virtual', 1500, '2018-07-09 09:34:42', 0);

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `id` bigint(20) NOT NULL,
  `id_barang` varchar(45) NOT NULL,
  `id_pembeli` varchar(45) NOT NULL,
  `jumlah` int(20) DEFAULT '1',
  `status` int(1) NOT NULL DEFAULT '0',
  `id_transaksi` varchar(45) DEFAULT NULL,
  `resi` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`id`, `id_barang`, `id_pembeli`, `jumlah`, `status`, `id_transaksi`, `resi`) VALUES
(20, 'ITEM0000000001', 'BYR0000000001', 3, 5, 'TR0000000001', '55555555'),
(21, 'ITEM0000000002', 'BYR0000000001', 4, 5, 'TR0000000001', '55555555'),
(22, 'ITEM0000000003', 'BYR0000000001', 5, 5, 'TR0000000001', '55555555'),
(23, 'ITEM0000000001', 'BYR0000000001', 2, 4, 'TR0000000002', '12121212'),
(25, 'ITEM0000000002', 'BYR0000000001', 1, 3, 'TR0000000003', NULL),
(26, 'ITEM0000000004', 'BYR0000000001', 1, 2, 'TR0000000003', NULL),
(27, 'ITEM0000000004', 'BYR0000000001', 1, 2, 'TR0000000004', NULL),
(28, 'ITEM0000000001', 'BYR0000000001', 1, 1, 'TR0000000005', NULL),
(29, 'ITEM0000000003', 'BYR0000000001', 1, 1, 'TR0000000005', NULL),
(30, 'ITEM0000000002', 'BYR0000000001', 1, 1, 'TR0000000005', NULL),
(31, 'ITEM0000000004', 'BYR0000000001', 1, 1, 'TR0000000005', NULL),
(32, 'ITEM0000000001', 'BYR0000000001', 1, 1, 'TR0000000006', '-'),
(33, 'ITEM0000000001', 'BYR0000000001', 1, 1, 'TR0000000007', 'Not Available'),
(34, 'ITEM0000000003', 'BYR0000000001', 1, 1, 'TR0000000007', 'Not Available'),
(35, 'ITEM0000000001', 'SLR0000000001', 6, 0, NULL, 'Not Available'),
(36, 'ITEM0000000005', 'SLR0000000001', 2, 0, NULL, 'Not Available'),
(37, 'ITEM0000000002', 'BYR0000000001', 5, 2, 'TR0000000008', 'Not Available'),
(38, 'ITEM0000000004', 'BYR0000000001', 5, 2, 'TR0000000008', 'Not Available');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `id_transaksi` varchar(45) NOT NULL,
  `tanggal` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `total` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`id_transaksi`, `tanggal`, `total`) VALUES
('TR0000000001', '2018-07-06 12:43:38', '18480000'),
('TR0000000002', '2018-07-06 12:43:51', '5000000'),
('TR0000000003', '2018-07-06 14:10:30', '172000'),
('TR0000000004', '2018-07-08 08:38:02', '52000'),
('TR0000000005', '2018-07-08 08:49:02', '4772000'),
('TR0000000006', '2018-07-08 08:54:46', '2500000'),
('TR0000000007', '2018-07-08 08:56:13', '4600000'),
('TR0000000008', '2018-07-09 15:14:19', '860000');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` varchar(45) NOT NULL,
  `password` varchar(64) DEFAULT NULL,
  `nama_lengkap` varchar(45) DEFAULT NULL,
  `jenis_kelamin` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `alamat` longtext,
  `nama_rekening` varchar(45) DEFAULT NULL,
  `no_rekening` varchar(20) DEFAULT NULL,
  `bank_rekening` varchar(45) DEFAULT NULL,
  `tipe` varchar(45) DEFAULT NULL,
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `password`, `nama_lengkap`, `jenis_kelamin`, `email`, `alamat`, `nama_rekening`, `no_rekening`, `bank_rekening`, `tipe`, `timestamp`) VALUES
('ADM0000000001', 'L2rdNUxZarrpwCvSqiyOoC4TqqYUrjYcGPmqg85YT0U=', 'AFTA DIZCA WAHANA', 'L', 'aftadizca@gmail.com', 'sidoarjo', 'afta dizca wahana', '12121212232', 'mandiri', 'ADMIN', '2018-07-04 14:00:15'),
('BYR0000000001', 'L2rdNUxZarrpwCvSqiyOoC4TqqYUrjYcGPmqg85YT0U=', 'AFTA DIZCA WAHANA', 'L', 'aftadizca@gmail.com', 'sidoarjo', 'afta dizca wahana', '12121212232', 'mandiri', 'BUYER', '2018-07-04 14:00:15'),
('SLR0000000001', 'L2rdNUxZarrpwCvSqiyOoC4TqqYUrjYcGPmqg85YT0U=', 'TOKO SAYA', NULL, 'aftadizca@gmail.com', NULL, NULL, NULL, NULL, 'SELLER', '2018-07-04 13:59:24'),
('SLR0000000002', 'EfPFzHhYHej1DRkxfOmIiF2g16sW49rkbEYFFfYIZNU=', 'TOKO SAYA 2', NULL, 'aftadizca@mail.com', NULL, NULL, NULL, NULL, 'SELLER', '2018-07-04 13:59:24');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barangdagangan`
--
ALTER TABLE `barangdagangan`
  ADD PRIMARY KEY (`id_barang`) USING BTREE,
  ADD KEY `id_penjual` (`id_penjual`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_transaksi_fk` (`id_transaksi`) USING BTREE,
  ADD KEY `id_barang_fk` (`id_barang`) USING BTREE,
  ADD KEY `id_pembeli_fk` (`id_pembeli`) USING BTREE;

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`id_transaksi`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idUser_UNIQUE` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `barangdagangan`
--
ALTER TABLE `barangdagangan`
  ADD CONSTRAINT `barangdagangan_ibfk_1` FOREIGN KEY (`id_penjual`) REFERENCES `user` (`id`);

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`id_pembeli`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `cart_ibfk_2` FOREIGN KEY (`id_barang`) REFERENCES `barangdagangan` (`id_barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
