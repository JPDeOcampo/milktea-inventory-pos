-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 01, 2022 at 12:58 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `omt`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_account`
--

CREATE TABLE `tbl_account` (
  `ID` int(11) NOT NULL,
  `firstname` text NOT NULL,
  `lastname` text NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `position` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_account`
--

INSERT INTO `tbl_account` (`ID`, `firstname`, `lastname`, `username`, `password`, `position`) VALUES
(1, 'a', 'a', 'a', 'a', 'Admin'),
(2, 'bdf', 'b', 'b', 'b', 'User'),
(3, 'a', 'a', 'a', 'a', 'Admin'),
(13, 'aqew', 'qwewqe', 'qwewe', '1234', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_classicmilktea`
--

CREATE TABLE `tbl_classicmilktea` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_classicmilktea`
--

INSERT INTO `tbl_classicmilktea` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(1040, 'Strawberry', '89.00', '50.70', '99.00', '68.25'),
(1041, 'Blueberry', '89.00', '50.70', '99.00', '32.45'),
(1042, 'Chocolate', '89.00', '46.00', '99.00', '74.25'),
(1043, 'Caramel', '89.00', '46.00', '99.00', '62.25'),
(1044, 'Mango', '89.00', '39.95', '99.00', '71.25'),
(1045, 'Lychee', '89.00', '0.00', '99.00', '0.00'),
(1046, 'Taro', '89.00', '53.25', '99.00', '74.80'),
(1047, 'Crème Brule', '89.00', '40.75', '99.00', '60.90');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_fruitteas`
--

CREATE TABLE `tbl_fruitteas` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_fruitteas`
--

INSERT INTO `tbl_fruitteas` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(2, 'Wintermelon', '85.00', '29.65', '95.00', '38.85'),
(3, 'Strawberry', '85.00', '32.65', '95.00', '44.10'),
(4, 'Blueberry', '85.00', '30.35', '95.00', '44.10'),
(5, 'Green Apple', '85.00', '29.85', '95.00', '36.30'),
(6, 'Lychee', '85.00', '30.50', '95.00', '37.05'),
(7, 'Peach', '85.00', '30.35', '95.00', '42.35'),
(8, 'Mango', '85.00', '30.35', '95.00', '44.10'),
(9, 'Passion Fruit', '85.00', '30.40', '95.00', '36.85'),
(10, 'Raspberry', '85.00', '30.60', '95.00', '37.05'),
(11, 'Kiwi', '85.00', '30.40', '95.00', '36.85');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_goldensugar`
--

CREATE TABLE `tbl_goldensugar` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_goldensugar`
--

INSERT INTO `tbl_goldensugar` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(1, 'Golden Sugar Bubble Drink', '115.00', '38.43', '125.00', '41.88'),
(2, 'Golden Sugar with Egg Pudding', '125.00', '33.93', '140.00', '41.88'),
(3, 'Golden Sugar Salted Cheese', '130.00', '42.18', '145.00', '51.78');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_milk`
--

CREATE TABLE `tbl_milk` (
  `ID` int(11) NOT NULL,
  `MilkItems` varchar(255) NOT NULL,
  `MilkPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_milk`
--

INSERT INTO `tbl_milk` (`ID`, `MilkItems`, `MilkPrice`) VALUES
(4401, 'Fresh Milk', 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_payment`
--

CREATE TABLE `tbl_payment` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(11) NOT NULL,
  `FQuantityM` int(11) NOT NULL,
  `MCapital` decimal(12,2) NOT NULL,
  `FQuantityL` int(11) NOT NULL,
  `LCapital` decimal(12,2) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  `SinkerName` varchar(30) NOT NULL,
  `SinkerQ` int(11) NOT NULL,
  `AdditionalPrice` decimal(12,2) NOT NULL,
  `TotalMProfit` decimal(12,2) NOT NULL,
  `TotalLProfit` decimal(12,2) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_payment`
--

INSERT INTO `tbl_payment` (`ID`, `FlavorItems`, `FQuantityM`, `MCapital`, `FQuantityL`, `LCapital`, `Price`, `SinkerName`, `SinkerQ`, `AdditionalPrice`, `TotalMProfit`, `TotalLProfit`, `Date`) VALUES
(1040, 'Strawberry', 1, '51.00', 0, '0.00', '89.00', '', 0, '0.00', '38.00', '0.00', '2019-12-16'),
(1042, 'Chocolate', 0, '0.00', 1, '74.00', '99.00', '', 0, '0.00', '0.00', '25.00', '2019-12-16'),
(1041, 'Blueberry', 1, '51.00', 1, '32.00', '188.00', '', 0, '0.00', '38.00', '67.00', '2019-12-16'),
(1042, 'Chocolate', 0, '0.00', 2, '148.00', '198.00', '', 0, '0.00', '0.00', '50.00', '2019-12-16'),
(1041, 'Blueberry', 1, '51.00', 1, '32.00', '188.00', '', 0, '0.00', '38.00', '67.00', '2019-12-16'),
(1044, 'Mango', 1, '40.00', 1, '71.00', '188.00', '', 0, '0.00', '49.00', '28.00', '2019-12-16'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-16'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-17'),
(1041, 'Blueberry', 1, '51.00', 0, '0.00', '99.00', 'Black Pearl', 1, '10.00', '38.00', '0.00', '2019-12-17'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-17'),
(1041, 'Blueberry', 1, '51.00', 1, '32.00', '188.00', '', 0, '0.00', '38.00', '67.00', '2019-12-17'),
(1042, 'Chocolate', 1, '46.00', 1, '74.00', '188.00', '', 0, '0.00', '43.00', '25.00', '2019-12-17'),
(1043, 'Caramel', 1, '46.00', 1, '62.00', '218.00', 'White Pearl', 3, '30.00', '43.00', '37.00', '2019-12-17'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-17'),
(4, 'Wintermelon', 1, '38.00', 1, '67.00', '187.00', '', 0, '0.00', '50.00', '32.00', '2019-12-17'),
(5, 'OMT Signatu', 1, '42.00', 0, '0.00', '89.00', '', 0, '0.00', '47.00', '0.00', '2019-12-17'),
(1, 'Ichi', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-01'),
(1, 'Ni', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-02'),
(1, 'San', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-03'),
(1, 'Shi', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-04'),
(1, 'Go', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-05'),
(1, 'Roku', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-06'),
(1, 'Nana', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-07'),
(1, 'Hachi', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-08'),
(1, 'Kyuu', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-09'),
(1, 'Juu', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-10'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2019-12-17'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '99.00', '', 0, '0.00', '0.00', '66.55', '2019-12-17'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '99.00', '', 0, '0.00', '0.00', '66.55', '2019-12-17'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2019-12-17'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '119.00', 'Nata', 3, '30.00', '38.30', '0.00', '2019-12-17'),
(5, 'Green Apple', 0, '0.00', 1, '51.35', '99.00', 'Nata', 0, '0.00', '0.00', '47.65', '2019-12-17'),
(4, 'Thai Carame', 3, '112.95', 0, '0.00', '284.00', 'Black Pearl', 2, '20.00', '151.05', '0.00', '2019-12-17'),
(1040, 'Strawberry', 1, '51.00', 0, '0.00', '89.00', '', 0, '0.00', '38.00', '0.00', '2019-12-16'),
(1042, 'Chocolate', 0, '0.00', 1, '74.00', '99.00', '', 0, '0.00', '0.00', '25.00', '2019-12-16'),
(1041, 'Blueberry', 1, '51.00', 1, '32.00', '188.00', '', 0, '0.00', '38.00', '67.00', '2019-12-16'),
(1042, 'Chocolate', 0, '0.00', 2, '148.00', '198.00', '', 0, '0.00', '0.00', '50.00', '2019-12-16'),
(1041, 'Blueberry', 1, '51.00', 1, '32.00', '188.00', '', 0, '0.00', '38.00', '67.00', '2019-12-16'),
(1044, 'Mango', 1, '40.00', 1, '71.00', '188.00', '', 0, '0.00', '49.00', '28.00', '2019-12-16'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-16'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-17'),
(1041, 'Blueberry', 1, '51.00', 0, '0.00', '99.00', 'Black Pearl', 1, '10.00', '38.00', '0.00', '2019-12-17'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-17'),
(1041, 'Blueberry', 1, '51.00', 1, '32.00', '188.00', '', 0, '0.00', '38.00', '67.00', '2019-12-17'),
(1042, 'Chocolate', 1, '46.00', 1, '74.00', '188.00', '', 0, '0.00', '43.00', '25.00', '2019-12-17'),
(1043, 'Caramel', 1, '46.00', 1, '62.00', '218.00', 'White Pearl', 3, '30.00', '43.00', '37.00', '2019-12-17'),
(1040, 'Strawberry', 1, '51.00', 1, '68.00', '188.00', '', 0, '0.00', '38.00', '31.00', '2019-12-17'),
(4, 'Wintermelon', 1, '38.00', 1, '67.00', '187.00', '', 0, '0.00', '50.00', '32.00', '2019-12-17'),
(5, 'OMT Signatu', 1, '42.00', 0, '0.00', '89.00', '', 0, '0.00', '47.00', '0.00', '2019-12-17'),
(1, 'Ichi', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-01'),
(1, 'Ni', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-02'),
(1, 'San', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-03'),
(1, 'Shi', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-04'),
(1, 'Go', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-05'),
(1, 'Roku', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-06'),
(1, 'Nana', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-07'),
(1, 'Hachi', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-08'),
(1, 'Kyuu', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-09'),
(1, 'Juu', 1, '50.50', 0, '0.00', '99.00', '', 0, '0.00', '48.50', '0.00', '2019-12-10'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2019-12-17'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '99.00', '', 0, '0.00', '0.00', '66.55', '2019-12-17'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '99.00', '', 0, '0.00', '0.00', '66.55', '2019-12-17'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2019-12-17'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '119.00', 'Nata', 3, '30.00', '38.30', '0.00', '2019-12-17'),
(5, 'Green Apple', 0, '0.00', 1, '51.35', '99.00', 'Nata', 0, '0.00', '0.00', '47.65', '2019-12-17'),
(4, 'Thai Carame', 3, '112.95', 0, '0.00', '284.00', 'Black Pearl', 2, '20.00', '151.05', '0.00', '2019-12-17'),
(1042, 'Chocolate', 1, '46.00', 0, '0.00', '89.00', '-----', 0, '0.00', '43.00', '0.00', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 0, '0.00', '89.00', '-----', 0, '0.00', '49.05', '0.00', '2020-02-15'),
(1042, 'Chocolate', 0, '0.00', 1, '74.25', '99.00', '-----', 0, '0.00', '0.00', '24.75', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '198.00', 'Coffee Jelly', 1, '10.00', '49.05', '27.75', '2020-02-15'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '198.00', 'Coffee Jelly', 1, '10.00', '43.00', '36.75', '2020-02-15'),
(1042, 'Chocolate', 0, '0.00', 1, '74.25', '109.00', 'Coffee Jelly', 1, '10.00', '0.00', '24.75', '2020-02-15'),
(1046, 'Taro', 1, '53.25', 0, '0.00', '99.00', 'Coffee Jelly', 1, '10.00', '35.75', '0.00', '2020-02-15'),
(4, 'Sour Apple ', 1, '37.65', 1, '67.05', '197.00', 'Coffee Jelly', 1, '10.00', '50.35', '31.95', '2020-02-15'),
(2, 'Peach Mango', 1, '0.00', 1, '67.05', '115.00', 'Coffee Jelly', 1, '10.00', '0.00', '37.95', '2020-02-15'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-02-15'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-02-15'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-02-15'),
(1045, 'Lychee', 1, '0.00', 1, '0.00', '188.00', '', 0, '0.00', '89.00', '99.00', '2020-02-15'),
(2, 'Thai Matcha', 1, '0.00', 1, '67.05', '105.00', '', 0, '0.00', '0.00', '37.95', '2020-02-15'),
(4, 'Thai Red Mi', 1, '37.65', 1, '67.05', '187.00', '', 0, '0.00', '50.35', '31.95', '2020-02-15'),
(2, 'Thai Matcha', 1, '0.00', 1, '67.05', '105.00', '', 0, '0.00', '0.00', '37.95', '2020-02-15'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-02-15'),
(1040, 'Strawberry', 1, '50.70', 1, '68.25', '188.00', '', 0, '0.00', '38.30', '30.75', '2020-02-15'),
(1045, 'Lychee', 0, '0.00', 1, '0.00', '99.00', '', 0, '0.00', '0.00', '99.00', '2020-02-15'),
(1041, 'Blueberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-15'),
(1046, 'Taro', 1, '53.25', 1, '74.80', '188.00', '', 0, '0.00', '35.75', '24.20', '2020-02-15'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '99.00', '', 0, '0.00', '0.00', '66.55', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 0, '0.00', '89.00', '', 0, '0.00', '49.05', '0.00', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 0, '0.00', '99.00', 'Black Pearl', 1, '10.00', '49.05', '0.00', '2020-02-15'),
(5, 'OMT Signatu', 1, '41.90', 1, '51.35', '188.00', '', 0, '0.00', '47.10', '47.65', '2020-02-15'),
(6, 'Roasted Ass', 1, '42.35', 1, '50.55', '187.00', '', 0, '0.00', '45.65', '48.45', '2020-02-15'),
(1041, 'Blueberry', 1, '0.00', 1, '32.45', '99.00', '', 0, '0.00', '0.00', '66.55', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 0, '0.00', '99.00', 'Egg Pudding', 1, '10.00', '49.05', '0.00', '2020-02-15'),
(1043, 'Caramel', 0, '0.00', 1, '32.45', '109.00', 'White Pearl', 1, '10.00', '0.00', '66.55', '2020-02-15'),
(1045, 'Lychee', 1, '0.00', 0, '0.00', '99.00', 'White Pearl', 1, '10.00', '89.00', '0.00', '2020-02-15'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-02-15'),
(1040, 'Strawberry', 1, '50.70', 1, '68.25', '188.00', '', 0, '0.00', '38.30', '30.75', '2020-02-15'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-02-15'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-02-15'),
(1046, 'Taro', 1, '53.25', 1, '74.80', '188.00', '', 0, '0.00', '35.75', '24.20', '2020-02-15'),
(1041, 'Blueberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-15'),
(1046, 'Taro', 0, '0.00', 1, '74.80', '99.00', '', 0, '0.00', '0.00', '24.20', '2020-02-15'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '198.00', 'Coffee Jelly', 1, '10.00', '43.00', '36.75', '2020-02-15'),
(4, 'Wintermelon', 0, '0.00', 1, '67.05', '109.00', 'Coffee Jelly', 1, '10.00', '0.00', '31.95', '2020-02-15'),
(6, 'Roasted Ass', 1, '42.35', 0, '0.00', '98.00', 'Coffee Jelly', 1, '10.00', '45.65', '0.00', '2020-02-15'),
(1042, 'Chocolate', 1, '46.00', 1, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-02-15'),
(1041, 'Blueberry', 1, '50.70', 1, '32.45', '188.00', '', 0, '0.00', '38.30', '66.55', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '188.00', '', 0, '0.00', '49.05', '27.75', '2020-02-15'),
(3, 'Thai Royal ', 0, '0.00', 1, '64.05', '105.00', '', 0, '0.00', '0.00', '40.95', '2020-02-15'),
(4, 'Thai Red Mi', 0, '0.00', 1, '67.05', '99.00', '', 0, '0.00', '0.00', '31.95', '2020-02-15'),
(1041, 'Blueberry', 1, '50.70', 1, '32.45', '188.00', '', 0, '0.00', '38.30', '66.55', '2020-02-15'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-02-15'),
(5, 'Wild Berry ', 0, '0.00', 1, '51.35', '99.00', '', 0, '0.00', '0.00', '47.65', '2020-02-15'),
(5, 'OMT Signatu', 1, '41.90', 1, '51.35', '188.00', '', 0, '0.00', '47.10', '47.65', '2020-02-15'),
(1045, 'Lychee', 1, '0.00', 1, '0.00', '188.00', '', 0, '0.00', '89.00', '99.00', '2020-02-15'),
(4, 'Thai Red Mi', 1, '37.65', 1, '67.05', '187.00', '', 0, '0.00', '50.35', '31.95', '2020-02-15'),
(2, 'Thai Matcha', 1, '0.00', 1, '67.05', '105.00', '', 0, '0.00', '0.00', '37.95', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 0, '0.00', '89.00', '', 0, '0.00', '49.05', '0.00', '2020-02-15'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '188.00', '', 0, '0.00', '49.05', '27.75', '2020-02-16'),
(5, 'OMT Signatu', 1, '41.90', 1, '51.35', '188.00', '', 0, '0.00', '47.10', '47.65', '2020-02-16'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-02-16'),
(1043, 'Caramel', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 1, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1042, 'Chocolate', 1, '46.00', 0, '0.00', '99.00', 'Egg Pudding', 1, '10.00', '43.00', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 1, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1043, 'Caramel', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 5, '253.50', 0, '0.00', '445.00', '', 0, '0.00', '191.50', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1044, 'Mango', 1, '39.95', 0, '0.00', '89.00', '', 0, '0.00', '49.05', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '89.00', '', 0, '0.00', '38.30', '0.00', '2020-02-16'),
(4, 'Wintermelon', 1, '37.65', 0, '0.00', '88.00', '', 0, '0.00', '50.35', '0.00', '2020-02-25'),
(5, 'OMT Signatu', 0, '0.00', 1, '51.35', '99.00', '', 0, '0.00', '0.00', '47.65', '2020-02-25'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-02-26'),
(1047, 'Crème Brule', 1, '40.75', 0, '0.00', '99.00', 'Nata', 1, '10.00', '48.25', '0.00', '2020-02-26'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '109.00', 'White Pearl', 1, '10.00', '0.00', '66.55', '2020-02-26'),
(1040, 'Strawberry', 1, '50.70', 0, '0.00', '99.00', 'White Pearl', 1, '10.00', '38.30', '0.00', '2020-02-26'),
(1041, 'Blueberry', 0, '0.00', 1, '32.45', '109.00', 'White Pearl', 1, '10.00', '0.00', '66.55', '2020-02-26'),
(1042, 'Chocolate', 0, '0.00', 1, '74.25', '99.00', '', 0, '0.00', '0.00', '24.75', '2020-02-26'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '188.00', '', 0, '0.00', '49.05', '27.75', '2020-03-04'),
(2, 'Thai Matcha', 0, '0.00', 1, '67.05', '105.00', '', 0, '0.00', '0.00', '37.95', '2020-03-04'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '188.00', '', 0, '0.00', '49.05', '27.75', '2020-03-04'),
(3, 'Thai Royal ', 0, '0.00', 1, '64.05', '105.00', '', 0, '0.00', '0.00', '40.95', '2020-03-04'),
(2, 'Wintermelon', 0, '0.00', 1, '67.05', '105.00', '', 0, '0.00', '0.00', '37.95', '2020-03-04'),
(1046, 'Taro', 1, '53.25', 0, '0.00', '89.00', '', 0, '0.00', '35.75', '0.00', '2020-03-04'),
(1042, 'Chocolate', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-03-04'),
(1045, 'Lychee', 0, '0.00', 1, '0.00', '10.00', 'Egg Pudding', 1, '10.00', '0.00', '0.00', '2020-03-04'),
(5, 'OMT Signatu', 1, '41.90', 0, '0.00', '10.00', 'Egg Pudding', 1, '10.00', '-41.90', '0.00', '2020-03-04'),
(1041, 'Blueberry', 1, '50.70', 1, '32.45', '188.00', '', 0, '0.00', '38.30', '66.55', '2020-03-04'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '188.00', '', 0, '0.00', '49.05', '27.75', '2020-03-04'),
(7, 'Peach', 1, '65.55', 1, '80.20', '270.00', '', 0, '0.00', '64.45', '59.80', '2020-03-04'),
(4, 'Wintermelon', 0, '0.00', 1, '67.05', '99.00', '', 0, '0.00', '0.00', '31.95', '2020-03-04'),
(4, 'Thai Red Mi', 1, '37.65', 0, '0.00', '88.00', '', 0, '0.00', '50.35', '0.00', '2020-03-04'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-03-04'),
(5, 'Green Apple', 1, '41.90', 1, '51.35', '198.00', 'Nata', 1, '10.00', '47.10', '47.65', '2020-03-04'),
(9, 'Passion Fru', 0, '0.00', 1, '36.85', '105.00', 'Nata', 1, '10.00', '0.00', '58.15', '2020-03-04'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-03-04'),
(3, 'Strawberrie', 1, '0.00', 1, '64.05', '105.00', '', 0, '0.00', '0.00', '40.95', '2020-03-04'),
(3, 'Golden Suga', 1, '0.00', 1, '64.05', '105.00', '', 0, '0.00', '0.00', '40.95', '2020-03-04'),
(3, 'Choco Straw', 1, '0.00', 1, '64.05', '105.00', '', 0, '0.00', '0.00', '40.95', '2020-03-04'),
(2, 'Peach Mango', 0, '0.00', 1, '67.05', '105.00', '', 0, '0.00', '0.00', '37.95', '2020-03-04'),
(1040, 'Strawberry', 0, '0.00', 1, '68.25', '99.00', '', 0, '0.00', '0.00', '30.75', '2020-03-04'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '188.00', '', 0, '0.00', '49.05', '27.75', '2020-03-04'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-03-04'),
(1045, 'Lychee', 1, '0.00', 1, '0.00', '188.00', '', 0, '0.00', '89.00', '99.00', '2020-03-04'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-03-04'),
(3, 'Choco Straw', 1, '0.00', 1, '64.05', '105.00', '', 0, '0.00', '0.00', '40.95', '2020-03-04'),
(4, 'Thai Red Mi', 1, '37.65', 1, '67.05', '187.00', '', 0, '0.00', '50.35', '31.95', '2020-03-04'),
(5, 'OMT Signatu', 1, '41.90', 1, '51.35', '188.00', '', 0, '0.00', '47.10', '47.65', '2020-03-04'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '188.00', '', 0, '0.00', '43.00', '24.75', '2020-03-04'),
(1042, 'Chocolate', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-03-04'),
(1045, 'Lychee', 1, '0.00', 0, '0.00', '89.00', '', 0, '0.00', '89.00', '0.00', '2020-03-04'),
(1047, 'Crème Brule', 2, '81.50', 0, '0.00', '178.00', '', 0, '0.00', '96.50', '0.00', '2020-03-04'),
(1042, 'Chocolate', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-03-04'),
(1045, 'Lychee', 1, '0.00', 0, '0.00', '89.00', '', 0, '0.00', '89.00', '0.00', '2020-03-04'),
(1041, 'Blueberry', 2, '101.40', 0, '0.00', '178.00', '', 0, '0.00', '76.60', '0.00', '2020-03-04'),
(1043, 'Caramel', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-03-04'),
(1043, 'Caramel', 1, '46.00', 1, '62.25', '188.00', '', 0, '0.00', '43.00', '36.75', '2020-03-04'),
(1043, 'Caramel', 1, '46.00', 0, '0.00', '89.00', '', 0, '0.00', '43.00', '0.00', '2020-03-04'),
(1044, 'Mango', 4, '159.80', 0, '0.00', '356.00', '', 0, '0.00', '196.20', '0.00', '2020-03-04'),
(1042, 'Chocolate', 5, '230.00', 6, '445.50', '1049.00', 'White Pearl', 1, '10.00', '215.00', '148.50', '2020-05-31'),
(1, 'White Rabbi', 1, '56.95', 1, '67.25', '270.00', 'White Pearl', 1, '10.00', '63.05', '72.75', '2021-09-14'),
(1044, 'Mango', 1, '39.95', 1, '71.25', '198.00', 'Nata', 1, '10.00', '49.05', '27.75', '2021-09-14'),
(1, 'Chessy Assa', 1, '56.95', 1, '67.25', '270.00', 'Egg Pudding', 1, '10.00', '63.05', '72.75', '2021-09-14'),
(4, 'Blueberry', 1, '37.65', 1, '67.05', '197.00', 'Nata', 1, '10.00', '50.35', '31.95', '2021-09-14'),
(1042, 'Chocolate', 1, '46.00', 1, '74.25', '198.00', 'Nata', 1, '10.00', '43.00', '24.75', '2021-09-14'),
(2, 'Thai Matcha', 1, '0.00', 1, '67.05', '115.00', 'Nata', 1, '10.00', '0.00', '37.95', '2021-09-14'),
(5, 'OMT Signatu', 1, '41.90', 1, '51.35', '198.00', 'White Pearl', 1, '10.00', '47.10', '47.65', '2021-09-14'),
(4, 'Wintermelon', 1, '37.65', 0, '0.00', '98.00', 'Black Pearl', 1, '10.00', '50.35', '0.00', '2022-10-01');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_powder`
--

CREATE TABLE `tbl_powder` (
  `ID` int(11) NOT NULL,
  `PowderItems` varchar(255) NOT NULL,
  `PowderPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_powder`
--

INSERT INTO `tbl_powder` (`ID`, `PowderItems`, `PowderPrice`) VALUES
(3301, 'Brown sugar', 5);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saltedcaramelcream`
--

CREATE TABLE `tbl_saltedcaramelcream` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_saltedcaramelcream`
--

INSERT INTO `tbl_saltedcaramelcream` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(2, 'Assam Salted Caramel Cream', '130.00', '66.55', '145.00', '74.35'),
(3, 'Wintermelon Salted Cream', '130.00', '61.85', '145.00', '72.05'),
(4, 'Thai Caramel Tea Cream', '130.00', '57.70', '145.00', '64.30'),
(5, 'Thai Matcha Caramel Cream', '130.00', '65.70', '145.00', '73.10'),
(6, 'Chocolate Caramel Cream', '130.00', '69.75', '140.00', '81.70'),
(7, 'Double Caramel Cream', '130.00', '65.55', '140.00', '80.20');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saltedcheeseblend`
--

CREATE TABLE `tbl_saltedcheeseblend` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_saltedcheeseblend`
--

INSERT INTO `tbl_saltedcheeseblend` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(1, 'Chessy Assam', '120.00', '56.95', '140.00', '67.25'),
(2, 'Wintermelon Cheese', '120.00', '52.15', '140.00', '57.95'),
(3, 'Strawberries & Cream', '120.00', '56.75', '140.00', '67.25'),
(4, 'Green Tea Delight', '120.00', '52.35', '140.00', '68.45'),
(5, 'Chocolate Cream', '120.00', '56.75', '140.00', '67.25');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_signaturemilktea`
--

CREATE TABLE `tbl_signaturemilktea` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_signaturemilktea`
--

INSERT INTO `tbl_signaturemilktea` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(4, 'Wintermelon', '88.00', '37.65', '99.00', '67.05'),
(5, 'OMT Signature Milk Tea', '89.00', '41.90', '99.00', '51.35'),
(6, 'Roasted Assam', '88.00', '42.35', '99.00', '50.55');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sinkers`
--

CREATE TABLE `tbl_sinkers` (
  `ID` int(11) NOT NULL,
  `SinkersItems` varchar(255) NOT NULL,
  `SinkersPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_sinkers`
--

INSERT INTO `tbl_sinkers` (`ID`, `SinkersItems`, `SinkersPrice`) VALUES
(1, 'Black Pearl', 10),
(2, 'White Pearl', 10),
(3, 'Nata', 10),
(4, 'Egg Pudding', 10),
(5, 'Coffee Jelly', 10),
(6, 'Popping Bobba', 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stocks`
--

CREATE TABLE `tbl_stocks` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_stocks`
--

INSERT INTO `tbl_stocks` (`ID`, `Name`, `Quantity`) VALUES
(1, 'Strawberry', 10),
(1040, 'Milk', 10),
(1041, 'cherry', 10),
(1043, 'mango', 10);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sweetsyrup`
--

CREATE TABLE `tbl_sweetsyrup` (
  `ID` int(11) NOT NULL,
  `SweetSyrupItems` varchar(255) NOT NULL,
  `SweetSyrupPrice` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_sweetsyrup`
--

INSERT INTO `tbl_sweetsyrup` (`ID`, `SweetSyrupItems`, `SweetSyrupPrice`) VALUES
(2201, 'Black Sugar', 5),
(2202, 'Golden Sugar', 15),
(2203, 'Simple', 15);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_thaiseries`
--

CREATE TABLE `tbl_thaiseries` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_thaiseries`
--

INSERT INTO `tbl_thaiseries` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(2, 'Thai Matcha', '99.00', '41.90', '109.00', '52.65'),
(3, 'Thai Royal Milk Tea', '99.00', '38.55', '109.00', '50.25'),
(4, 'Thai Red Milk Tea', '99.00', '109.00', '33.90', '43.85');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_whiterabbitcandy`
--

CREATE TABLE `tbl_whiterabbitcandy` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_whiterabbitcandy`
--

INSERT INTO `tbl_whiterabbitcandy` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(1, 'White Rabbit Candy', '120.00', '47.80', '135.00', '57.10');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_yakultfusion`
--

CREATE TABLE `tbl_yakultfusion` (
  `ID` int(11) NOT NULL,
  `FlavorItems` varchar(40) NOT NULL,
  `MediumPrice` decimal(12,2) NOT NULL,
  `MediumCapital` decimal(12,2) NOT NULL,
  `LargePrice` decimal(12,2) NOT NULL,
  `LargeCapital` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_yakultfusion`
--

INSERT INTO `tbl_yakultfusion` (`ID`, `FlavorItems`, `MediumPrice`, `MediumCapital`, `LargePrice`, `LargeCapital`) VALUES
(2, 'Peach MangoYakult', '0.00', '0.00', '105.00', '67.05'),
(3, 'Choco Strawberry Yakult', '0.00', '0.00', '105.00', '64.05'),
(4, 'Sour Apple  Yakult', '0.00', '0.00', '105.00', '57.45'),
(5, 'Wild Berry Yakult', '0.00', '0.00', '105.00', '65.90');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_account`
--
ALTER TABLE `tbl_account`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_classicmilktea`
--
ALTER TABLE `tbl_classicmilktea`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_fruitteas`
--
ALTER TABLE `tbl_fruitteas`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_goldensugar`
--
ALTER TABLE `tbl_goldensugar`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_milk`
--
ALTER TABLE `tbl_milk`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_powder`
--
ALTER TABLE `tbl_powder`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_saltedcaramelcream`
--
ALTER TABLE `tbl_saltedcaramelcream`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_saltedcheeseblend`
--
ALTER TABLE `tbl_saltedcheeseblend`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_signaturemilktea`
--
ALTER TABLE `tbl_signaturemilktea`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_sinkers`
--
ALTER TABLE `tbl_sinkers`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_stocks`
--
ALTER TABLE `tbl_stocks`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_sweetsyrup`
--
ALTER TABLE `tbl_sweetsyrup`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_thaiseries`
--
ALTER TABLE `tbl_thaiseries`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_whiterabbitcandy`
--
ALTER TABLE `tbl_whiterabbitcandy`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_yakultfusion`
--
ALTER TABLE `tbl_yakultfusion`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_account`
--
ALTER TABLE `tbl_account`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbl_classicmilktea`
--
ALTER TABLE `tbl_classicmilktea`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1049;

--
-- AUTO_INCREMENT for table `tbl_fruitteas`
--
ALTER TABLE `tbl_fruitteas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbl_goldensugar`
--
ALTER TABLE `tbl_goldensugar`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_milk`
--
ALTER TABLE `tbl_milk`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4403;

--
-- AUTO_INCREMENT for table `tbl_powder`
--
ALTER TABLE `tbl_powder`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3302;

--
-- AUTO_INCREMENT for table `tbl_saltedcaramelcream`
--
ALTER TABLE `tbl_saltedcaramelcream`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_saltedcheeseblend`
--
ALTER TABLE `tbl_saltedcheeseblend`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_signaturemilktea`
--
ALTER TABLE `tbl_signaturemilktea`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_sinkers`
--
ALTER TABLE `tbl_sinkers`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbl_stocks`
--
ALTER TABLE `tbl_stocks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1044;

--
-- AUTO_INCREMENT for table `tbl_thaiseries`
--
ALTER TABLE `tbl_thaiseries`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_whiterabbitcandy`
--
ALTER TABLE `tbl_whiterabbitcandy`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_yakultfusion`
--
ALTER TABLE `tbl_yakultfusion`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
