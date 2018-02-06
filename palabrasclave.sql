-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-09-2017 a las 00:34:10
-- Versión del servidor: 10.1.10-MariaDB
-- Versión de PHP: 5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `palabrasclave`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `auditivo`
--

CREATE TABLE `auditivo` (
  `idPalabra` int(11) NOT NULL,
  `Palabras` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `auditivo`
--

INSERT INTO `auditivo` (`idPalabra`, `Palabras`) VALUES
(1, 'alto'),
(2, 'claro'),
(3, 'suena'),
(4, 'escuchar'),
(5, 'gritar'),
(6, 'decir'),
(7, 'proclamar'),
(8, 'escuchar'),
(9, 'escuche'),
(10, 'grite'),
(11, 'dije'),
(12, 'sonaba'),
(13, 'musica\r\n'),
(14, 'oir'),
(15, 'relatar'),
(16, 'arritmico'),
(17, 'relatar'),
(18, 'susurrar'),
(19, 'pronunciar'),
(20, 'cancion'),
(22, 'preguntar'),
(23, 'pregunto'),
(24, 'mencionar'),
(25, 'discutir'),
(26, 'mencione'),
(27, 'menciono'),
(28, 'discutir'),
(29, 'discuti'),
(30, 'hablar'),
(31, 'hable'),
(32, 'hablamos'),
(33, 'armonia'),
(34, 'tono'),
(35, 'tempo'),
(36, 'desafinado'),
(37, 'estrepitoso'),
(38, 'eco'),
(39, 'gruñido'),
(40, 'timbre'),
(41, 'intenso'),
(42, 'afinado'),
(43, 'musica'),
(44, 'sonido'),
(45, 'lejano'),
(46, 'cercanop'),
(47, 'fuerte'),
(48, 'melodioso'),
(49, 'melodia'),
(50, 'sonara');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `kinestesico`
--

CREATE TABLE `kinestesico` (
  `idPalabra` int(11) NOT NULL,
  `Palabras` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `kinestesico`
--

INSERT INTO `kinestesico` (`idPalabra`, `Palabras`) VALUES
(1, 'movimiento'),
(2, 'textura'),
(3, 'arrullo'),
(4, 'vertigo'),
(5, 'sentir'),
(6, 'tocar'),
(7, 'acariciar'),
(8, 'rigido'),
(9, 'gravedad'),
(10, 'rosar'),
(11, 'sostener'),
(12, 'ambiente'),
(13, 'agarrar'),
(14, 'percibir'),
(15, 'abrazar'),
(16, 'relajante'),
(17, 'estimulante'),
(18, 'pesar'),
(19, 'calido'),
(20, 'acojedor'),
(21, 'aburrido'),
(22, 'frieldad'),
(23, 'suave'),
(24, 'solido'),
(25, 'firme'),
(26, 'aguado'),
(27, 'frajil'),
(28, 'resistente'),
(29, 'compacto'),
(30, 'dulce'),
(31, 'salado'),
(32, 'amargo'),
(33, 'picante'),
(34, 'caliente'),
(35, 'frio'),
(36, 'esponjoso'),
(37, 'blando'),
(38, 'rugoso'),
(39, 'pulido'),
(40, 'terso'),
(41, 'sabroso'),
(42, 'agrio'),
(43, 'fresco'),
(44, 'aspero'),
(45, 'tentar'),
(46, 'sobar'),
(47, 'corrioso'),
(48, 'delicado'),
(49, 'peludo'),
(50, 'tibio'),
(51, 'templado'),
(52, 'liso'),
(53, 'bordeado'),
(54, 'poroso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `visual`
--

CREATE TABLE `visual` (
  `idPalabra` int(11) NOT NULL,
  `Palabras` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `visual`
--

INSERT INTO `visual` (`idPalabra`, `Palabras`) VALUES
(1, 'opaco'),
(2, 'brillante'),
(3, 'admirar'),
(4, 'fotografia'),
(5, 'video'),
(6, 'profundidad'),
(7, 'peliculas'),
(8, 'lejos'),
(9, 'cerca'),
(10, 'señas'),
(11, 'vizualisar'),
(12, 'perspectiva'),
(13, 'observar'),
(14, 'imagen'),
(15, 'ilustrar'),
(16, 'notar'),
(17, 'vision'),
(18, 'visualizar'),
(19, 'negrura'),
(20, 'graficar'),
(21, 'colorido'),
(22, 'empalidecer'),
(23, 'reflejar'),
(24, 'resplandeciente'),
(25, 'soleado'),
(26, 'mirar'),
(27, 'claro'),
(28, 'oscuro'),
(29, 'panorama'),
(30, 'minimalista');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `auditivo`
--
ALTER TABLE `auditivo`
  ADD PRIMARY KEY (`idPalabra`);

--
-- Indices de la tabla `kinestesico`
--
ALTER TABLE `kinestesico`
  ADD PRIMARY KEY (`idPalabra`);

--
-- Indices de la tabla `visual`
--
ALTER TABLE `visual`
  ADD PRIMARY KEY (`idPalabra`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `auditivo`
--
ALTER TABLE `auditivo`
  MODIFY `idPalabra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;
--
-- AUTO_INCREMENT de la tabla `kinestesico`
--
ALTER TABLE `kinestesico`
  MODIFY `idPalabra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;
--
-- AUTO_INCREMENT de la tabla `visual`
--
ALTER TABLE `visual`
  MODIFY `idPalabra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
