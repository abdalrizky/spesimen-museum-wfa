-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 17, 2025 at 01:08 AM
-- Server version: 8.4.3
-- PHP Version: 8.3.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `spesimen_museum`
--
CREATE DATABASE IF NOT EXISTS `spesimen_museum` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `spesimen_museum`;

-- --------------------------------------------------------

--
-- Table structure for table `collection_storages`
--

DROP TABLE IF EXISTS `collection_storages`;
CREATE TABLE `collection_storages` (
  `id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `location` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `credentials`
--

DROP TABLE IF EXISTS `credentials`;
CREATE TABLE `credentials` (
  `id` int NOT NULL,
  `role_id` int NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `favorite_speciments`
--

DROP TABLE IF EXISTS `favorite_speciments`;
CREATE TABLE `favorite_speciments` (
  `id` int NOT NULL,
  `credential_id` int NOT NULL,
  `speciment_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `id` int NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`id`, `name`) VALUES
(1, 'admin'),
(2, 'biologist'),
(3, 'visitor');

-- --------------------------------------------------------

--
-- Table structure for table `speciments`
--

DROP TABLE IF EXISTS `speciments`;
CREATE TABLE `speciments` (
  `id` int NOT NULL,
  `collection_storage_id` int NOT NULL,
  `common_name` varchar(100) NOT NULL,
  `scientific_name` varchar(100) NOT NULL,
  `family` varchar(100) NOT NULL,
  `preservation_method` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `photo_path` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `collection_storages`
--
ALTER TABLE `collection_storages`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `credentials`
--
ALTER TABLE `credentials`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `fk_credentials_roles` (`role_id`);

--
-- Indexes for table `favorite_speciments`
--
ALTER TABLE `favorite_speciments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_favorite_speciments_credentials` (`credential_id`),
  ADD KEY `fk_favorite_speciments_speciments` (`speciment_id`);

--
-- Indexes for table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `speciments`
--
ALTER TABLE `speciments`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_speciments_collection_storages` (`collection_storage_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `collection_storages`
--
ALTER TABLE `collection_storages`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `credentials`
--
ALTER TABLE `credentials`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `favorite_speciments`
--
ALTER TABLE `favorite_speciments`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `speciments`
--
ALTER TABLE `speciments`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `credentials`
--
ALTER TABLE `credentials`
  ADD CONSTRAINT `fk_credentials_roles` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Constraints for table `favorite_speciments`
--
ALTER TABLE `favorite_speciments`
  ADD CONSTRAINT `fk_favorite_speciments_credentials` FOREIGN KEY (`credential_id`) REFERENCES `credentials` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `fk_favorite_speciments_speciments` FOREIGN KEY (`speciment_id`) REFERENCES `speciments` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Constraints for table `speciments`
--
ALTER TABLE `speciments`
  ADD CONSTRAINT `fk_speciments_collection_storages` FOREIGN KEY (`collection_storage_id`) REFERENCES `collection_storages` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
