/*
Navicat MySQL Data Transfer

Source Server         : LOCAL
Source Server Version : 50736
Source Host           : localhost:3306
Source Database       : empresa_servicios

Target Server Type    : MYSQL
Target Server Version : 50736
File Encoding         : 65001

Date: 2022-03-14 16:11:47
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for bitacora
-- ----------------------------
DROP TABLE IF EXISTS `bitacora`;
CREATE TABLE `bitacora` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_empleado` int(11) DEFAULT NULL,
  `fecha_evento` datetime DEFAULT NULL,
  `id_evento` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_empleado` (`id_empleado`),
  KEY `id_evento` (`id_evento`),
  CONSTRAINT `bitacora_ibfk_1` FOREIGN KEY (`id_empleado`) REFERENCES `cat_empleados` (`id`),
  CONSTRAINT `bitacora_ibfk_2` FOREIGN KEY (`id_evento`) REFERENCES `cat_eventos_sistema` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bitacora
-- ----------------------------
INSERT INTO `bitacora` VALUES ('1', '1', '2022-03-07 10:34:24', '1');
INSERT INTO `bitacora` VALUES ('2', '1', '2022-03-07 10:42:02', '1');
INSERT INTO `bitacora` VALUES ('3', '1', '2022-03-07 10:42:15', '2');
INSERT INTO `bitacora` VALUES ('4', '1', '2022-03-07 10:43:52', '2');
INSERT INTO `bitacora` VALUES ('5', '1', '2022-03-07 10:50:17', '1');
INSERT INTO `bitacora` VALUES ('6', '1', '2022-03-07 10:50:19', '2');
INSERT INTO `bitacora` VALUES ('7', '1', '2022-03-11 12:47:36', '1');
INSERT INTO `bitacora` VALUES ('8', '1', '2022-03-11 12:47:51', '2');
INSERT INTO `bitacora` VALUES ('9', '1', '2022-03-11 12:55:16', '1');
INSERT INTO `bitacora` VALUES ('10', '1', '2022-03-11 12:56:06', '2');
INSERT INTO `bitacora` VALUES ('11', '1', '2022-03-11 12:56:11', '1');
INSERT INTO `bitacora` VALUES ('12', '1', '2022-03-11 13:00:30', '2');
INSERT INTO `bitacora` VALUES ('13', '1', '2022-03-11 13:00:35', '1');
INSERT INTO `bitacora` VALUES ('14', '1', '2022-03-11 13:14:33', '2');
INSERT INTO `bitacora` VALUES ('15', '1', '2022-03-11 13:14:39', '1');
INSERT INTO `bitacora` VALUES ('16', '1', '2022-03-11 13:15:23', '2');
INSERT INTO `bitacora` VALUES ('17', '1', '2022-03-11 13:15:28', '1');
INSERT INTO `bitacora` VALUES ('18', '1', '2022-03-11 13:17:32', '2');
INSERT INTO `bitacora` VALUES ('19', '1', '2022-03-11 13:17:36', '1');
INSERT INTO `bitacora` VALUES ('20', '1', '2022-03-11 13:19:14', '1');
INSERT INTO `bitacora` VALUES ('21', '1', '2022-03-11 13:19:28', '2');
INSERT INTO `bitacora` VALUES ('22', '1', '2022-03-11 13:19:31', '1');
INSERT INTO `bitacora` VALUES ('23', '1', '2022-03-11 13:22:25', '2');
INSERT INTO `bitacora` VALUES ('24', '1', '2022-03-11 13:22:32', '1');
INSERT INTO `bitacora` VALUES ('25', '1', '2022-03-11 13:40:34', '2');
INSERT INTO `bitacora` VALUES ('26', '1', '2022-03-11 13:40:39', '1');
INSERT INTO `bitacora` VALUES ('27', '1', '2022-03-11 13:41:23', '2');
INSERT INTO `bitacora` VALUES ('28', '1', '2022-03-11 13:41:28', '1');
INSERT INTO `bitacora` VALUES ('29', '1', '2022-03-11 17:24:00', '2');
INSERT INTO `bitacora` VALUES ('30', '1', '2022-03-14 09:08:54', '1');

-- ----------------------------
-- Table structure for cat_empleados
-- ----------------------------
DROP TABLE IF EXISTS `cat_empleados`;
CREATE TABLE `cat_empleados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `apepat` varchar(100) DEFAULT NULL,
  `apemat` varchar(100) DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `fecha_nac` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cat_empleados
-- ----------------------------
INSERT INTO `cat_empleados` VALUES ('1', 'ROMÁN', 'AMAVIZCA', 'RIGOBERTO', '1978-10-20');
INSERT INTO `cat_empleados` VALUES ('2', 'ROMÁN', 'RUIZ', 'LUZ MARÍA', '2006-04-20');
INSERT INTO `cat_empleados` VALUES ('3', 'RUIZ', 'FUENTES', 'MARTHA', '2012-02-08');

-- ----------------------------
-- Table structure for cat_eventos_sistema
-- ----------------------------
DROP TABLE IF EXISTS `cat_eventos_sistema`;
CREATE TABLE `cat_eventos_sistema` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cat_eventos_sistema
-- ----------------------------
INSERT INTO `cat_eventos_sistema` VALUES ('1', 'Entro a Sistema');
INSERT INTO `cat_eventos_sistema` VALUES ('2', 'Salió del Sistema');

-- ----------------------------
-- Table structure for cat_usuarios
-- ----------------------------
DROP TABLE IF EXISTS `cat_usuarios`;
CREATE TABLE `cat_usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) DEFAULT NULL,
  `clave` varchar(50) DEFAULT NULL,
  `id_empleado` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_empleado` (`id_empleado`),
  CONSTRAINT `cat_usuarios_ibfk_1` FOREIGN KEY (`id_empleado`) REFERENCES `cat_empleados` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cat_usuarios
-- ----------------------------
INSERT INTO `cat_usuarios` VALUES ('1', 'rigo', '111', '1');
INSERT INTO `cat_usuarios` VALUES ('2', 'celeste', '222', '2');
