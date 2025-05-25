-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-05-2025 a las 20:29:48
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `cajeroautomaticodb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `DUI` char(9) NOT NULL,
  `Correo` varchar(150) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `TipoCuenta` enum('Corriente','Ahorro') NOT NULL,
  `PIN` varchar(64) NOT NULL,
  `Saldo` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`ID`, `Nombre`, `Apellido`, `DUI`, `Correo`, `Telefono`, `TipoCuenta`, `PIN`, `Saldo`) VALUES
(2, 'Sofia', 'Romero', '149809027', 'sofia.romero1@gmail.com', '86245958', 'Corriente', 'ed6dea48048cfd0c2ececb0e80c6c3b992165dcac4d45528909d9b53164cd79a', 2312.53),
(3, 'Diego', 'Lopez', '525572995', 'diego.lopez2@gmail.com', '33256879', 'Ahorro', '20bc9a3dbbc8e2f1e83cde8a0dabe43f558426a140b6dddc7f451b018283a906', 2015.32),
(4, 'Camila', 'Castillo', '253891953', 'camila.castillo3@gmail.com', '93376476', 'Corriente', '3d49ab508c58b7a14622eb81075e157505aa65c881f27bae82915b0f9742724c', 2350.99),
(5, 'Mateo', 'Garcia', '430849212', 'mateo.garcia4@gmail.com', '55586235', 'Ahorro', '7bd341f08056de72d77d24aa5bc681dcb485b628df4fd03179e30ee2bc01f097', 1518.94),
(6, 'Valentina', 'Diaz', '756973652', 'valentina.diaz5@gmail.com', '26422476', 'Ahorro', '202fd26f14d638ccb40975163ab0f05e1acf24c04a30708b3e0abfac44301a08', 1065.96),
(7, 'Luis', 'Navarro', '026527361', 'luis.navarro6@gmail.com', '75837287', 'Corriente', '8861a3ae97ede98c3bee152161a40b497095a5b0e1f5785efdd46fcc4a984b86', 1106.48),
(8, 'Lucia', 'Ortega', '233004800', 'lucia.ortega7@gmail.com', '98962553', 'Ahorro', '024e63e143c4b74cdac88952f787759c4430a26b008ed906cf25779619e481b7', 2952.12),
(9, 'Juan', 'Alvarez', '689837239', 'juan.alvarez8@gmail.com', '38497733', 'Ahorro', 'b0193ceb57d22ae3f35716d0e3d5ee4a45452b7b3af33fdc710013b6a65b3b67', 1859.63),
(10, 'Isabella', 'Mendez', '871605311', 'isabella.mendez9@gmail.com', '45573649', 'Ahorro', '4e9bc236f7ca5be2bf7486c7e2bfea03b532e765325d6a72329fd75f695a0228', 365.16),
(11, 'Gabriel', 'Reyes', '891496203', 'gabriel.reyes10@gmail.com', '68825593', 'Corriente', '0d589a18c4705f5616ce3205ad85bd59da85fa0c40eaefbee054f7f863f3cb1a', 2793.83),
(12, 'Emilia', 'Pineda', '717295921', 'emilia.pineda11@gmail.com', '37238267', 'Ahorro', 'b954bc4acaad1bfa43689f654027227c6cd416e797fbf7ddbd2a38864d857a5e', 2421.08),
(13, 'Andres', 'Carrillo', '925131391', 'andres.carrillo12@gmail.com', '59482868', 'Ahorro', 'e3ddd04bb0a8ca43b7d0acb1352eed64047dd634a95007e3c4d3bd274ee97155', 1678.52),
(14, 'Daniela', 'Velasquez', '599555218', 'daniela.velasquez13@gmail.com', '92523332', 'Ahorro', '9689b85f503ae43133a5e45660386ceb88f5839ce249081343a64162d46687be', 2995.28),
(15, 'Joaquin', 'Molina', '177965738', 'joaquin.molina14@gmail.com', '24265788', 'Corriente', 'eb51f8315cf769b317615f7fcbdad3ff8612baaea0e9a39d3a63550c44784658', 2520.38),
(16, 'Renata', 'Rios', '575621673', 'renata.rios15@gmail.com', '84535873', 'Ahorro', 'c5067bcbc573d35e3788d098a8d58772fc5717e120b4990f8bcbfd634e45853a', 1436.26),
(17, 'Sebastian', 'Vega', '533066683', 'sebastian.vega16@gmail.com', '94553377', 'Ahorro', '958c9e58139db36e4a6d03be9c17a9a2d6a7e8494769aaab7a79c739d41ac2ef', 2571.76),
(18, 'Martina', 'Campos', '340961862', 'martina.campos17@gmail.com', '62398688', 'Ahorro', '3fe9eb6564da9fb4b187ca4cc5110944704d53bde5691f3ea57d3fa53c7c7be3', 2511.65),
(19, 'Julian', 'Mejia', '400150907', 'julian.mejia18@gmail.com', '87576254', 'Ahorro', '0e6da782fd921bc121dc0eeb0218d17fcfdd566b898c241b32a9835a35fc24e5', 1969.19),
(20, 'Paula', 'Serrano', '571783131', 'paula.serrano19@gmail.com', '33878368', 'Corriente', '6395d074384a7076ef14af955956d3ea38952a9d7781a321b74c954da32f2dd6', 844.87),
(21, 'Fernando', 'Delgado', '571761293', 'fernando.delgado20@gmail.com', '64383256', 'Corriente', 'b687b757bd658e9ae5624be7705283c8d3a560d9dc488f8413d3bd91aa183d5e', 1335.88),
(22, 'Valeria', 'Estrada', '312013531', 'valeria.estrada21@gmail.com', '44339354', 'Corriente', '320c68a7652ebd0afd027fd6d07517f8b5341ac23f6fce03259f9a0f65114b7b', 2749.47),
(23, 'Bruno', 'Guerrero', '803723085', 'bruno.guerrero22@gmail.com', '65397339', 'Ahorro', 'dafff407d7450f62b0dd0c413f9f0745d70071b8ba4d731d093804be0502184e', 1609.48),
(24, 'Mariana', 'Chavez', '707039412', 'mariana.chavez23@gmail.com', '66849385', 'Ahorro', '96b6182f87ded1baa28f8ef40c8cf03714642fa3846be3d8be9170f0d604aabc', 2614.49),
(25, 'Nicolas', 'Salazar', '892237335', 'nicolas.salazar24@gmail.com', '98536788', 'Corriente', '42a8d10424653fc26a1319a0c7f84ea30f43c8a009e7d99fcd9e8151332bdcf3', 2009.22),
(26, 'Florencia', 'Luna', '292404228', 'florencia.luna25@gmail.com', '47694756', 'Corriente', 'b3e34e9fe5a79d4e8753d0ad4107d0af969d8faaefb88fbd68316950fa2a9242', 2464.94),
(27, 'Alex', 'Cornejo', '622592888', 'alex.cornejo26@gmail.com', '99999624', 'Ahorro', 'ac74ca8a7cddeb3c89b2ea19fb59e8bc9fbe112e5b98f21c6b89eb3e3aaec9e7', 1578.30),
(28, 'Emma', 'Arce', '755515289', 'emma.arce27@gmail.com', '29255384', 'Ahorro', '8ba89f83a19745038de329531b2e1c2b1d58b6d7f7e2a22e993024a1b78adeba', 1884.54),
(29, 'Tomas', 'Palacios', '178062578', 'tomas.palacios28@gmail.com', '86363356', 'Ahorro', 'ad5393c506d4ea318f814f75abf4c15a97967933a34adfed92d6cb12efb5d5b0', 288.50),
(30, 'Julieta', 'Aguilar', '368149815', 'julieta.aguilar29@gmail.com', '67482778', 'Corriente', '44e2740e4e8f1d14b3a36c4208eca571cca80075bfd0b446c580d3d8e1188c2e', 2888.21),
(31, 'Facundo', 'Cruz', '048658797', 'facundo.cruz30@gmail.com', '26664726', 'Corriente', '76cf2aaa3d5feafddfd466dc0c5ceae90392e7af89b4ad0f38591e036f2f1b00', 819.89),
(32, 'Bianca', 'Cardenas', '580413829', 'bianca.cardenas31@gmail.com', '65963345', 'Corriente', '9955f4a562efd60e9e84fb2ae6530fd781f06724fad301713d2fdc262a2f635d', 1034.85),
(33, 'Maximo', 'Zamora', '668166845', 'maximo.zamora32@gmail.com', '22377854', 'Corriente', '27b5f3558e46ebadd7b69497fa9b6f2230e2139bc7d70846b896fb8030236f2f', 2797.22),
(34, 'Carla', 'Lozano', '425767488', 'carla.lozano33@gmail.com', '66237545', 'Ahorro', '5f0e92362198dc68190b3e7ba044e6475ae036de70be6536a056de57290d3a03', 1647.28),
(35, 'Benjamin', 'Ayala', '654447644', 'benjamin.ayala34@gmail.com', '66238388', 'Ahorro', 'b4a906ff5d63dd73f46a93d31d43b493da0c06d4e1e071d84584e3a1d550feae', 1751.65),
(36, 'Mia', 'Rivas', '238316351', 'mia.rivas35@gmail.com', '25787285', 'Corriente', '5fa75ee2c5383fa601a45136751b99f41f203754378c650440e94c75020b70b0', 2315.50),
(37, 'Axel', 'Villalobos', '308806653', 'axel.villalobos36@gmail.com', '59453979', 'Corriente', '2f4627f93dcb6d9f60031c5cb881be652315df1fced864eb99ebbd19ba067644', 1583.76),
(38, 'Elena', 'Barahona', '176924168', 'elena.barahona37@gmail.com', '66446786', 'Corriente', '0c9de27d6a59e0356abcc7b5127f362ebf23dc41edb5c45473fccb38d633c6c5', 292.31),
(39, 'Leon', 'Monterrosa', '895766442', 'leon.monterrosa38@gmail.com', '23472487', 'Ahorro', '03314112b449d57cc9e5f8f56dcb4a453e605e7c26bf6aea84a86357336a85bf', 2979.15),
(40, 'Laura', 'Bonilla', '310258120', 'laura.bonilla39@gmail.com', '98295676', 'Ahorro', '69769ab78b2e30ed39fa27bb7f273a074ebebb9e2ab82b2f9c00f36f3abdb851', 1852.64),
(41, 'Alan', 'Caceres', '928384449', 'alan.caceres40@gmail.com', '38936558', 'Corriente', '6606753e5a126d7068012a526d44c3eb2f7fcd09d5faeb30c77dbfd87ca7e758', 2047.58),
(42, 'Catalina', 'Funes', '008254957', 'catalina.funes41@gmail.com', '39635783', 'Ahorro', 'b2b48d24f7d0790f675afa9f9b5252e57edc7ba0d438811789f3602a52019bb7', 1175.23),
(43, 'Erick', 'Herrera', '860388363', 'erick.herrera42@gmail.com', '36788285', 'Corriente', 'd83e303f681b94d24fdb0c6e7a1e730b964953b70284cfd9d55dbe096281058a', 1619.32),
(44, 'Naomi', 'Padilla', '334211875', 'naomi.padilla43@gmail.com', '33564463', 'Corriente', '625bcac215cfcfd03dc281e64d5e5598984ee23732a518516a25d0741a063c82', 2656.57),
(45, 'Santiago', 'Vasquez', '844905356', 'santiago.vasquez44@gmail.com', '64996528', 'Ahorro', '957b0d9447b1490029bfad564ef9e413db71d0353d0ce26f9dc43dce1308c17e', 2284.27),
(46, 'Fatima', 'Medina', '143441561', 'fatima.medina45@gmail.com', '44943793', 'Ahorro', '2a14e0e74f5b626ed7eed6bda430a7d5c8c338b7371284799059f546a0f611bc', 168.68),
(47, 'Andres', 'Morales', '326564170', 'andres.morales46@gmail.com', '32573249', 'Corriente', '04aa39fcb509e7842f0bd5b135b6181b0b57c8a74422838362f430351fc364f2', 2761.75),
(48, 'Nicole', 'Peña', '512578506', 'nicole.peña47@gmail.com', '28436775', 'Ahorro', '83a78b3a435a3355e1d7e4e73e7ced5a2e580695d3df036d0ba96bb16a91696b', 1239.14),
(49, 'Cristian', 'Gomez', '360071770', 'cristian.gomez48@gmail.com', '43755522', 'Corriente', 'c9916ca5880d11008999dc266d47657e927fde740bb899caa52ca5528da796b2', 303.04),
(50, 'Luna', 'Rosales', '274985039', 'luna.rosales49@gmail.com', '36586259', 'Ahorro', 'd70ada757917455ce5a436e921854e35871e9e368050c3681c94ca9435c71c66', 227.20),
(51, 'Marco', 'Sanchez', '451237153', 'marco.sanchez50@gmail.com', '42273948', 'Ahorro', '3217efb0c7592918e22986cb85ff86d1a7bbc81b6a293403235ebb2f952f6a1c', 139.81),
(52, 'axel', 'her', '777777777', 'dsa@g', '88888888', 'Ahorro', '0ffe1abd1a08215353c233d6e009613e95eec4253832a761af28ff37ac5a150c', 1000.20),
(53, 'qqq', 'www', '999999999', 'dsax@', '88888888', 'Corriente', '9af15b336e6a9619928537df30b2e6a2376569fcf9d7e773eccede65606529a0', 500.00),
(54, 'r', 'f', '555555555', 'd', '78787878', 'Ahorro', 'd7697570462f7562b83e81258de0f1e41832e98072e44c36ec8efec46786e24e', 300.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentasexternas`
--

CREATE TABLE `cuentasexternas` (
  `ID` int(11) NOT NULL,
  `Banco` varchar(100) NOT NULL,
  `Cuenta` varchar(12) NOT NULL,
  `Usuario` varchar(100) NOT NULL,
  `Valor` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cuentasexternas`
--

INSERT INTO `cuentasexternas` (`ID`, `Banco`, `Cuenta`, `Usuario`, `Valor`) VALUES
(1, 'Cuscatlan', '136854298521', 'Andres Garcia', 10.20),
(3, 'Banco Agrícola', '19823745', 'sofia', 125.50),
(4, 'Davivienda', '29384756', 'diego', 240.75),
(5, 'Scotiabank', '38475692', 'camila', 312.00),
(6, 'Banco Hipotecario', '47586931', 'mateo', 98.25),
(7, 'Banco Agrícola', '58273645', 'valeria', 450.00),
(8, 'Davivienda', '67238456', 'lucas', 50.30),
(9, 'Scotiabank', '73849501', 'isabella', 85.75),
(10, 'Banco Hipotecario', '84920384', 'sebastian', 135.00),
(11, 'Banco Agrícola', '95038475', 'mariana', 389.90),
(12, 'Davivienda', '10394857', 'alejandro', 72.45),
(13, 'Scotiabank', '11283745', 'sofia', 200.00),
(14, 'Banco Hipotecario', '12837465', 'camila', 180.99),
(15, 'Banco Agrícola', '13746592', 'mateo', 300.40),
(16, 'Davivienda', '14398576', 'diego', 91.10),
(17, 'Scotiabank', '15473820', 'lucas', 47.85),
(18, 'Banco Hipotecario', '16274839', 'valeria', 260.00),
(19, 'Banco Agrícola', '17839204', 'mariana', 145.30),
(20, 'Davivienda', '18374659', 'alejandro', 390.20),
(21, 'Scotiabank', '19485730', 'isabella', 110.60),
(22, 'Banco Hipotecario', '20485937', 'sebastian', 285.15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `ID` int(11) NOT NULL,
  `NumeroPago` char(5) NOT NULL,
  `Tipo` enum('Agua','Luz','Telefono') NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `Estado` enum('Pendiente','Pagado') DEFAULT 'Pendiente',
  `Fecha` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`ID`, `NumeroPago`, `Tipo`, `Monto`, `Estado`, `Fecha`) VALUES
(1, '19382', 'Luz', 45.75, 'Pendiente', '2025-05-25 13:42:30'),
(2, '24817', 'Agua', 37.50, 'Pendiente', '2025-05-25 13:42:30'),
(3, '39028', 'Telefono', 29.99, 'Pendiente', '2025-05-25 13:42:30'),
(4, '57293', 'Luz', 60.00, 'Pendiente', '2025-05-25 13:42:30'),
(5, '18492', 'Agua', 42.30, 'Pendiente', '2025-05-25 13:42:30'),
(6, '68293', 'Telefono', 35.50, 'Pendiente', '2025-05-25 13:42:30'),
(7, '18273', 'Luz', 58.20, 'Pendiente', '2025-05-25 13:42:30'),
(8, '98374', 'Agua', 40.00, 'Pendiente', '2025-05-25 13:42:30'),
(9, '76482', 'Telefono', 33.25, 'Pendiente', '2025-05-25 13:42:30'),
(10, '32847', 'Luz', 47.00, 'Pendiente', '2025-05-25 13:42:30'),
(11, '23418', 'Agua', 36.80, 'Pendiente', '2025-05-25 13:42:30'),
(12, '91827', 'Telefono', 31.99, 'Pendiente', '2025-05-25 13:42:30'),
(13, '76832', 'Luz', 52.40, 'Pendiente', '2025-05-25 13:42:30'),
(14, '13284', 'Agua', 39.90, 'Pendiente', '2025-05-25 13:42:30'),
(15, '38271', 'Telefono', 30.00, 'Pendiente', '2025-05-25 13:42:30'),
(16, '56473', 'Luz', 61.10, 'Pendiente', '2025-05-25 13:42:30'),
(17, '84736', 'Agua', 43.75, 'Pendiente', '2025-05-25 13:42:30'),
(18, '14253', 'Telefono', 27.99, 'Pendiente', '2025-05-25 13:42:30'),
(19, '45362', 'Luz', 59.95, 'Pendiente', '2025-05-25 13:42:30'),
(20, '64738', 'Agua', 41.60, 'Pendiente', '2025-05-25 13:42:30');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamos`
--

CREATE TABLE `prestamos` (
  `ID` int(11) NOT NULL,
  `ClienteID` int(11) NOT NULL,
  `MontoTotal` decimal(10,2) NOT NULL,
  `SaldoPendiente` decimal(10,2) NOT NULL,
  `Estado` enum('Activo','Pagado') DEFAULT 'Activo',
  `Fecha` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `remesas`
--

CREATE TABLE `remesas` (
  `ID` int(11) NOT NULL,
  `Codigo` varchar(8) NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `Remitente` varchar(100) NOT NULL,
  `Destinatario` varchar(100) NOT NULL,
  `Estado` enum('Pendiente','Retirado') DEFAULT 'Pendiente',
  `FechaCreacion` timestamp NOT NULL DEFAULT current_timestamp(),
  `FechaRetiro` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transacciones`
--

CREATE TABLE `transacciones` (
  `ID` int(11) NOT NULL,
  `ClienteID` int(11) NOT NULL,
  `Tipo` enum('Retiro','Deposito','Pago','Remesa','Transferencia') NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `CuentaDestino` int(11) DEFAULT NULL,
  `Fecha` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuariosbanco`
--

CREATE TABLE `usuariosbanco` (
  `ID` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Apellido` varchar(100) NOT NULL,
  `DUI` char(9) NOT NULL,
  `Correo` varchar(150) NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `PIN` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuariosbanco`
--

INSERT INTO `usuariosbanco` (`ID`, `Nombre`, `Apellido`, `DUI`, `Correo`, `Telefono`, `PIN`) VALUES
(14, 'Juan', 'Perez', '012345678', 'juan.perez@mail.com', '76543210', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),
(15, 'Maria', 'Gomez', '112233445', 'maria.gomez@mail.com', '71234567', 'f8638b979b2f4f793ddb6dbd197e0ee25a7a6ea32b0ae22f5e3c5d119d839e75'),
(16, 'Carlos', 'Ruiz', '987654321', 'carlos.ruiz@mail.com', '79876543', '8cce10345c5e1de90d277b9869465f5972b828afbbbfd7ef08b1d835eedee993'),
(17, 'Ana', 'Martinez', '334455667', 'ana.martinez@mail.com', '73456789', 'ceaa28bba4caba687dc31b1bbe79eca3c70c33f871f1ce8f528cf9ab5cfd76dd'),
(18, 'Luis', 'Hernandez', '445566778', 'luis.hernandez@mail.com', '74445555', '6a95bbab63d587b596398c4bd7e91a132f24032d2007d107e5ea71967724b092'),
(19, 'Elena', 'Castro', '556677889', 'elena.castro@mail.com', '75554444', 'a1fb4e703a9ef1fa4936801721ff285a97ac85330856674412e054892afe6972'),
(20, 'Daniel', 'Lopez', '667788990', 'daniel.lopez@mail.com', '76663333', 'f3e055913a0b1eb0f07317896f9a1bc466b9a50db85a7f882f3ffde9ffb23aca'),
(21, 'Sofia', 'Ramirez', '778899001', 'sofia.ramirez@mail.com', '77772222', 'b03fad7e896f0497f4f3c88a5bb083c8976608495abbf14b476e6a4bb6fd2c7f'),
(22, 'Roberto', 'Vasquez', '889900112', 'roberto.vasquez@mail.com', '78881111', '0a4e3e70597a358b9447fa8a647aadf5b76dde95c8e4ab02e5f8cee6caa1cd28'),
(23, 'Gabriela', 'Ortega', '990011223', 'gabriela.ortega@mail.com', '79990000', 'e4ed4d14170e2017c139c958853c66f4cecd6b43c12b0e0c641f4288bd859d93'),
(24, 'asd', 'dede', '777777777', 'as@gmail.com', '88888888', 'edee29f882543b956620b26d0ee0e7e950399b1c4222f5de05e06425b4c995e9'),
(25, 't', 'y', '555555555', 'd', '45612333', '07334386287751ba02a4588c1a0875dbd074a61bd9e6ab7c48d244eacd0c99e0');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `DUI` (`DUI`),
  ADD UNIQUE KEY `Correo` (`Correo`);

--
-- Indices de la tabla `cuentasexternas`
--
ALTER TABLE `cuentasexternas`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Cuenta` (`Cuenta`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `NumeroPago` (`NumeroPago`);

--
-- Indices de la tabla `prestamos`
--
ALTER TABLE `prestamos`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ClienteID` (`ClienteID`);

--
-- Indices de la tabla `remesas`
--
ALTER TABLE `remesas`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Codigo` (`Codigo`);

--
-- Indices de la tabla `transacciones`
--
ALTER TABLE `transacciones`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ClienteID` (`ClienteID`),
  ADD KEY `CuentaDestino` (`CuentaDestino`);

--
-- Indices de la tabla `usuariosbanco`
--
ALTER TABLE `usuariosbanco`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `DUI` (`DUI`),
  ADD UNIQUE KEY `Correo` (`Correo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT de la tabla `cuentasexternas`
--
ALTER TABLE `cuentasexternas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `prestamos`
--
ALTER TABLE `prestamos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `remesas`
--
ALTER TABLE `remesas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `transacciones`
--
ALTER TABLE `transacciones`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuariosbanco`
--
ALTER TABLE `usuariosbanco`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `prestamos`
--
ALTER TABLE `prestamos`
  ADD CONSTRAINT `prestamos_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `clientes` (`ID`);

--
-- Filtros para la tabla `transacciones`
--
ALTER TABLE `transacciones`
  ADD CONSTRAINT `transacciones_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `clientes` (`ID`),
  ADD CONSTRAINT `transacciones_ibfk_2` FOREIGN KEY (`CuentaDestino`) REFERENCES `clientes` (`ID`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
