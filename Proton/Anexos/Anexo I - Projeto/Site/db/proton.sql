-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 13, 2016 at 06:52 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proton`
--

-- --------------------------------------------------------

--
-- Table structure for table `historico`
--

CREATE TABLE `historico` (
  `idhistorico` int(11) NOT NULL,
  `idpaciente` int(11) NOT NULL,
  `data` date NOT NULL,
  `texto` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `medico`
--

CREATE TABLE `medico` (
  `idmedico` int(11) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `nome` int(11) NOT NULL,
  `especialidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `paciente`
--

CREATE TABLE `paciente` (
  `idpaciente` int(11) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `senha` varchar(30) NOT NULL,
  `cpf` int(20) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `idade` int(10) NOT NULL,
  `datanasc` date NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `celular` varchar(15) NOT NULL,
  `emerg_nome` varchar(80) NOT NULL,
  `emerg_tel` varchar(15) NOT NULL,
  `emerg_cel` varchar(15) NOT NULL,
  `lesoes` int(5) NOT NULL,
  `lesoes_cm` text NOT NULL,
  `fumante` int(5) NOT NULL,
  `marcapasso` int(5) NOT NULL,
  `marcapasso_cm` text NOT NULL,
  `hipertensao` int(5) NOT NULL,
  `hipertensao_cm` text NOT NULL,
  `epilepsia` int(5) NOT NULL,
  `epilepsia_cm` text NOT NULL,
  `atfisica` int(5) NOT NULL,
  `atfisica_cm` text NOT NULL,
  `alergic` int(5) NOT NULL,
  `alergic_cm` text NOT NULL,
  `diabetes` int(5) NOT NULL,
  `diabetes_cm` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `historico`
--
ALTER TABLE `historico`
  ADD PRIMARY KEY (`idhistorico`);

--
-- Indexes for table `medico`
--
ALTER TABLE `medico`
  ADD PRIMARY KEY (`idmedico`);

--
-- Indexes for table `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`idpaciente`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `historico`
--
ALTER TABLE `historico`
  MODIFY `idhistorico` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `medico`
--
ALTER TABLE `medico`
  MODIFY `idmedico` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `paciente`
--
ALTER TABLE `paciente`
  MODIFY `idpaciente` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
