/*
Navicat MySQL Data Transfer

Source Server         : LOCAL
Source Server Version : 50736
Source Host           : localhost:3306
Source Database       : empresa_servicios

Target Server Type    : MYSQL
Target Server Version : 50736
File Encoding         : 65001

Date: 2022-03-04 14:05:31
*/

SET FOREIGN_KEY_CHECKS=0;

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cat_empleados
-- ----------------------------
INSERT INTO `cat_empleados` VALUES ('1', 'Román', 'Amavizca', 'Rigoberto', '1978-10-20');
INSERT INTO `cat_empleados` VALUES ('2', 'Román', 'Ruiz', 'María Celeste', '2006-04-03');

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
