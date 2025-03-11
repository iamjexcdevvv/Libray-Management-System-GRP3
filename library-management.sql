-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 11, 2025 at 02:49 AM
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
-- Database: `library-management`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `bookID` int(11) NOT NULL,
  `bookISBN` varchar(128) NOT NULL DEFAULT 'None',
  `bookTitle` varchar(128) NOT NULL DEFAULT 'None',
  `bookAuthor` varchar(128) NOT NULL DEFAULT 'None',
  `bookGenre` varchar(128) NOT NULL DEFAULT 'None',
  `bookPublisher` varchar(128) NOT NULL DEFAULT 'None',
  `bookCover` longblob NOT NULL,
  `bookStatus` tinyint(1) NOT NULL DEFAULT 0,
  `bookPublishedDate` varchar(128) NOT NULL DEFAULT 'None'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `book_reservation`
--

CREATE TABLE `book_reservation` (
  `studentID` int(11) NOT NULL,
  `bookID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `borrowers`
--

CREATE TABLE `borrowers` (
  `id` int(11) NOT NULL,
  `studentID` int(11) NOT NULL,
  `bookID` int(11) NOT NULL,
  `issueDate` varchar(128) NOT NULL,
  `dueDate` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `borrow_request`
--

CREATE TABLE `borrow_request` (
  `studentID` int(11) NOT NULL,
  `bookID` int(11) NOT NULL,
  `borrowRequestDate` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(128) NOT NULL DEFAULT 'None',
  `email` varchar(128) NOT NULL DEFAULT 'None',
  `studentPassword` varchar(128) NOT NULL DEFAULT 'None',
  `studentName` varchar(128) NOT NULL DEFAULT 'None',
  `studentGender` varchar(128) NOT NULL DEFAULT 'None',
  `studentRole` varchar(128) NOT NULL DEFAULT 'Student',
  `studentProfile` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`bookID`);

--
-- Indexes for table `book_reservation`
--
ALTER TABLE `book_reservation`
  ADD UNIQUE KEY `studentID` (`studentID`,`bookID`),
  ADD KEY `reservation_bookid` (`bookID`);

--
-- Indexes for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD PRIMARY KEY (`id`),
  ADD KEY `bookid` (`bookID`),
  ADD KEY `studentid` (`studentID`);

--
-- Indexes for table `borrow_request`
--
ALTER TABLE `borrow_request`
  ADD UNIQUE KEY `studentID` (`studentID`,`bookID`),
  ADD KEY `borrowerbookid` (`bookID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `bookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;

--
-- AUTO_INCREMENT for table `borrowers`
--
ALTER TABLE `borrowers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=65;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `book_reservation`
--
ALTER TABLE `book_reservation`
  ADD CONSTRAINT `reservation_bookid` FOREIGN KEY (`bookID`) REFERENCES `books` (`bookID`) ON DELETE CASCADE,
  ADD CONSTRAINT `studentidreservation` FOREIGN KEY (`studentID`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `borrowers`
--
ALTER TABLE `borrowers`
  ADD CONSTRAINT `bookid` FOREIGN KEY (`bookID`) REFERENCES `books` (`bookID`) ON DELETE CASCADE,
  ADD CONSTRAINT `studentid` FOREIGN KEY (`studentID`) REFERENCES `users` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `borrow_request`
--
ALTER TABLE `borrow_request`
  ADD CONSTRAINT `borrowerbookid` FOREIGN KEY (`bookID`) REFERENCES `books` (`bookID`) ON DELETE CASCADE,
  ADD CONSTRAINT `borrowerstudentid` FOREIGN KEY (`studentID`) REFERENCES `users` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
