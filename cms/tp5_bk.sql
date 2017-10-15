/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50621
Source Host           : 127.0.0.1:3306
Source Database       : cms10

Target Server Type    : MYSQL
Target Server Version : 50621
File Encoding         : 65001

Date: 2017-09-09 09:46:54
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tp_advertisement`
-- ----------------------------
DROP TABLE IF EXISTS `tp_advertisement`;
CREATE TABLE `tp_advertisement` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'id',
  `title` varchar(50) NOT NULL COMMENT '广告名称',
  `title_alias` char(40) NOT NULL DEFAULT '' COMMENT '标识',
  `link_url` varchar(255) NOT NULL DEFAULT '' COMMENT '链接地址',
  `image_url` varchar(255) NOT NULL DEFAULT '' COMMENT '图片地址',
  `width` varchar(10) NOT NULL DEFAULT '' COMMENT '图片宽',
  `height` varchar(10) NOT NULL DEFAULT '' COMMENT '图片高',
  `intro` text NOT NULL COMMENT '广告描述',
  `click_count` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '点击数',
  `start_time` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '开始时间',
  `expired_time` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '过期时间',
  `attach_file` varchar(100) NOT NULL DEFAULT '' COMMENT '附件',
  `sort_order` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '排序',
  `status_is` enum('Y','N') NOT NULL DEFAULT 'Y' COMMENT '状态',
  `create_time` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '录入时间',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COMMENT='广告';

-- ----------------------------
-- Records of tp_advertisement
-- ----------------------------
INSERT INTO `tp_advertisement` VALUES ('4', '111', '12123', '12123', '12123', '12123', '12123', '12123', '0', '0', '0', '20170724/6bba83ba12e43a8b7f98c14c5cf29b34.jpeg', '13', 'Y', '1970');
INSERT INTO `tp_advertisement` VALUES ('5', '2222', '12', '12', 'https://ss0.bdstatic.com/5aV1bjqh_Q23odCf/static/superman/img/logo/bd_logo1_31bdc765.png', '1212', '2112', '1212', '0', '1500869121', '1499247921', '', '1', 'N', '2017');
INSERT INTO `tp_advertisement` VALUES ('6', '12', '12', '1212', '1212', '', '', '', '0', '0', '0', '20170724/4d7b2addc5dd79c332742a1d928da8f1.jpeg', '0', 'Y', '1500889711');

-- ----------------------------
-- Table structure for `tp_client`
-- ----------------------------
DROP TABLE IF EXISTS `tp_client`;
CREATE TABLE `tp_client` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Uid` int(10) DEFAULT '0' COMMENT '用户ID',
  `Cid` int(10) DEFAULT '0' COMMENT '默认联系人ID',
  `CompanyName` char(60) DEFAULT NULL COMMENT '公司名称',
  `Address` char(100) DEFAULT NULL COMMENT '详细地址',
  `ZipCode` char(10) DEFAULT NULL COMMENT '邮编',
  `WebUrl` varchar(60) DEFAULT NULL COMMENT '网站地址',
  `Industry` tinyint(4) DEFAULT '0' COMMENT '属所行业',
  `ClientType` tinyint(4) DEFAULT '0' COMMENT '客户类型',
  `ClientLevel` tinyint(4) DEFAULT '0' COMMENT '客户级别',
  `ClientSource` tinyint(4) DEFAULT '0' COMMENT '客户来源',
  `FollowUp` tinyint(4) DEFAULT '0' COMMENT '跟进情况',
  `Wast` tinyint(4) DEFAULT '0' COMMENT '跟单类型',
  `Intent` tinyint(4) DEFAULT '0' COMMENT '户客意向',
  `MainItems` varchar(200) DEFAULT NULL COMMENT '主营项目',
  `Message` varchar(1000) DEFAULT NULL COMMENT '备注，其它',
  `OpenShare` tinyint(1) DEFAULT '0' COMMENT '是否共享',
  `Share` varchar(500) DEFAULT NULL COMMENT '针对共享',
  `Recycle` tinyint(1) DEFAULT '0' COMMENT '是否在回收站',
  `Dtime` datetime DEFAULT NULL COMMENT '录入时间',
  `FinalTime` datetime DEFAULT NULL COMMENT '最后更新时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_client
-- ----------------------------
INSERT INTO `tp_client` VALUES ('14', '1', '15', '华为admin', 'xx', '43432', 'wqwqq', '34', '7', '16', '11', '55', '46', '58', '', '', '0', null, '0', '2016-12-03 11:46:07', '2016-12-03 11:46:07');
INSERT INTO `tp_client` VALUES ('15', '1', '16', '小米admin', '上升的', '3232', 'sdcx', '34', '7', '16', '11', '55', '46', '58', '', '', '0', null, '0', '2016-12-03 11:46:45', '2016-12-03 11:46:45');
INSERT INTO `tp_client` VALUES ('16', '5', '17', '特步wade', '都试试', '2112', 'qas', '34', '7', '16', '11', '55', '46', '58', '', '', '0', null, '0', '2016-12-03 11:52:32', '2016-12-03 11:52:32');
INSERT INTO `tp_client` VALUES ('17', '5', '18', '李宁wade', '', '', '', '34', '7', '16', '11', '55', '46', '58', '', '', '0', null, '0', '2016-12-03 11:53:08', '2016-12-03 11:53:08');
INSERT INTO `tp_client` VALUES ('18', '8', '19', '蒙牛小张', '是多少', '2323', '双肾', '34', '7', '16', '11', '55', '46', '58', '', '', '0', null, '0', '2016-12-03 11:54:23', '2016-12-03 11:54:23');
INSERT INTO `tp_client` VALUES ('19', '8', '20', '伊利小张', '', '', '', '34', '7', '16', '11', '55', '46', '58', '', '', '0', null, '0', '2016-12-03 11:54:46', '2016-12-03 11:54:46');
INSERT INTO `tp_client` VALUES ('20', '1', '21', 'wade', 'wade', 'wade', 'wade', '0', '0', '0', '0', '0', '0', '0', '', '', '0', null, '0', '2017-01-04 16:48:53', '2017-01-04 16:48:53');
INSERT INTO `tp_client` VALUES ('21', '1', '22', '1', '2', '3', '4', '0', '0', '0', '0', '0', '0', '0', '', '', '0', null, '1', '2017-01-04 16:54:17', '2017-01-04 16:54:17');

-- ----------------------------
-- Table structure for `tp_competence`
-- ----------------------------
DROP TABLE IF EXISTS `tp_competence`;
CREATE TABLE `tp_competence` (
  `ID` int(5) NOT NULL AUTO_INCREMENT COMMENT 'ID编号',
  `Sid` int(5) DEFAULT '0' COMMENT '权限分组',
  `Cname` varchar(20) DEFAULT '' COMMENT '权限名称',
  `Description` varchar(50) DEFAULT '' COMMENT '说明',
  `Status` tinyint(2) DEFAULT '0' COMMENT '状态',
  `Dtime` datetime DEFAULT NULL COMMENT '时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=120 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_competence
-- ----------------------------
INSERT INTO `tp_competence` VALUES ('1', '0', '用户管理', '登录用户管理', '0', '2013-12-08 17:08:27');
INSERT INTO `tp_competence` VALUES ('2', '1', '用户列表', '', '0', '2013-12-08 17:08:47');
INSERT INTO `tp_competence` VALUES ('3', '1', '添加用户', '', '0', '2013-12-08 17:08:54');
INSERT INTO `tp_competence` VALUES ('4', '1', '修改用户', '', '0', '2013-12-08 17:09:02');
INSERT INTO `tp_competence` VALUES ('5', '1', '删除用户', '', '0', '2017-02-21 11:17:13');
INSERT INTO `tp_competence` VALUES ('6', '0', '角色管理', '角色、级别分类', '0', '2013-12-08 17:09:53');
INSERT INTO `tp_competence` VALUES ('7', '6', '浏览角色', '', '0', '2013-12-08 17:10:03');
INSERT INTO `tp_competence` VALUES ('8', '6', '添加角色', '', '0', '2013-12-08 17:10:14');
INSERT INTO `tp_competence` VALUES ('9', '6', '修改角色', '', '0', '2013-12-08 17:10:24');
INSERT INTO `tp_competence` VALUES ('10', '6', '删除角色', '', '0', '2013-12-08 17:10:33');
INSERT INTO `tp_competence` VALUES ('11', '0', '权限列表', '对权限、功能的管理、操作需谨慎', '0', '2013-12-08 17:11:27');
INSERT INTO `tp_competence` VALUES ('12', '11', '浏览权限', '', '0', '2013-12-08 17:11:38');
INSERT INTO `tp_competence` VALUES ('13', '11', '添加权限', '', '0', '2013-12-08 17:11:47');
INSERT INTO `tp_competence` VALUES ('14', '11', '修改权限', '', '0', '2013-12-08 17:11:54');
INSERT INTO `tp_competence` VALUES ('15', '11', '删除权限', '', '0', '2013-12-08 17:12:04');
INSERT INTO `tp_competence` VALUES ('16', '0', '系统管理', '对系统管理的设置、修改', '0', '2013-12-08 17:15:50');
INSERT INTO `tp_competence` VALUES ('17', '0', '其它权限', '其它琐碎、无关痛痒的操作', '0', '2013-12-08 17:16:22');
INSERT INTO `tp_competence` VALUES ('18', '17', '修改资料', '', '0', '2013-12-08 17:17:09');
INSERT INTO `tp_competence` VALUES ('19', '107', '登录日志查看', '', '0', '2017-08-15 09:27:07');
INSERT INTO `tp_competence` VALUES ('20', '107', '删除登录日志', '', '0', '2017-08-15 09:27:14');
INSERT INTO `tp_competence` VALUES ('21', '111', 'IP封禁管理', '', '0', '2017-08-15 09:32:54');
INSERT INTO `tp_competence` VALUES ('22', '111', '添加封禁IP', '', '0', '2017-08-15 09:33:02');
INSERT INTO `tp_competence` VALUES ('23', '111', '删除封禁IP', '', '0', '2017-08-15 09:33:08');
INSERT INTO `tp_competence` VALUES ('24', '17', '清空缓存', '清空文件缓存、日志等', '0', '2017-08-15 09:33:25');
INSERT INTO `tp_competence` VALUES ('25', '106', '模块管理', '后台功能模块管理', '0', '2017-08-15 09:25:07');
INSERT INTO `tp_competence` VALUES ('26', '106', '添加模块', '', '0', '2017-08-15 09:25:16');
INSERT INTO `tp_competence` VALUES ('27', '106', '修改模块', '', '0', '2017-08-15 09:25:22');
INSERT INTO `tp_competence` VALUES ('28', '106', '删除模块', '', '0', '2017-08-15 09:25:28');
INSERT INTO `tp_competence` VALUES ('44', '0', '新闻管理', '', '0', '2017-08-15 09:39:51');
INSERT INTO `tp_competence` VALUES ('45', '112', '分类管理', '管理单页分类', '0', '2017-08-15 09:34:16');
INSERT INTO `tp_competence` VALUES ('46', '112', '添加分类', '', '0', '2017-08-15 09:34:23');
INSERT INTO `tp_competence` VALUES ('47', '112', '修改分类', '', '0', '2017-08-15 09:34:29');
INSERT INTO `tp_competence` VALUES ('48', '112', '删除分类', '', '0', '2017-08-15 09:34:33');
INSERT INTO `tp_competence` VALUES ('49', '44', '添加新闻', '', '0', '2017-08-15 09:40:46');
INSERT INTO `tp_competence` VALUES ('50', '44', '修改新闻', '', '0', '2017-08-15 09:40:52');
INSERT INTO `tp_competence` VALUES ('51', '44', '删除新闻', '', '0', '2017-08-15 09:40:58');
INSERT INTO `tp_competence` VALUES ('59', '0', '下拉菜单', '管理下拉菜单', '0', '2013-12-29 22:34:23');
INSERT INTO `tp_competence` VALUES ('60', '59', '浏览下拉菜单', '', '0', '2017-02-21 09:43:58');
INSERT INTO `tp_competence` VALUES ('61', '59', '添加下拉菜单', '', '0', '2013-12-29 22:34:55');
INSERT INTO `tp_competence` VALUES ('62', '59', '修改下拉菜单', '', '0', '2013-12-29 22:35:05');
INSERT INTO `tp_competence` VALUES ('63', '59', '删除下拉菜单', '', '0', '2013-12-29 22:35:16');
INSERT INTO `tp_competence` VALUES ('82', '108', '操作日志', '', '0', '2017-08-15 09:27:21');
INSERT INTO `tp_competence` VALUES ('83', '108', '删除操作日志', '', '0', '2017-08-15 09:27:36');
INSERT INTO `tp_competence` VALUES ('84', '44', '内容列表', '', '0', '2014-01-21 21:22:26');
INSERT INTO `tp_competence` VALUES ('91', '0', '友情链接', '', '0', '2017-07-12 11:44:49');
INSERT INTO `tp_competence` VALUES ('92', '91', '浏览友情链接', '', '0', '2017-07-12 11:45:24');
INSERT INTO `tp_competence` VALUES ('93', '91', '添加友情链接', '', '0', '2017-07-12 11:45:38');
INSERT INTO `tp_competence` VALUES ('94', '91', '修改友情链接', '', '0', '2017-07-12 11:45:50');
INSERT INTO `tp_competence` VALUES ('95', '91', '删除友情链接', '', '0', '2017-07-12 11:46:10');
INSERT INTO `tp_competence` VALUES ('96', '0', '广告管理', '', '0', '2017-07-24 17:31:41');
INSERT INTO `tp_competence` VALUES ('97', '96', '浏览广告', '', '0', '2017-07-24 17:32:44');
INSERT INTO `tp_competence` VALUES ('98', '96', '添加广告', '', '0', '2017-07-24 17:32:38');
INSERT INTO `tp_competence` VALUES ('99', '96', '修改广告', '', '0', '2017-07-24 17:32:18');
INSERT INTO `tp_competence` VALUES ('100', '96', '删除广告', '', '0', '2017-07-24 17:32:27');
INSERT INTO `tp_competence` VALUES ('101', '0', '商品管理', '', '0', '2017-08-14 16:14:43');
INSERT INTO `tp_competence` VALUES ('102', '101', '浏览商品', '', '0', '2017-08-14 16:15:04');
INSERT INTO `tp_competence` VALUES ('103', '101', '添加商品', '', '0', '2017-08-14 16:15:13');
INSERT INTO `tp_competence` VALUES ('104', '101', '修改商品', '', '0', '2017-08-14 16:15:29');
INSERT INTO `tp_competence` VALUES ('105', '101', '删除商品', '', '0', '2017-08-14 16:15:37');
INSERT INTO `tp_competence` VALUES ('106', '0', '模块管理', '', '0', '2017-08-15 09:24:49');
INSERT INTO `tp_competence` VALUES ('107', '0', '登录日志管理', '', '0', '2017-08-15 09:26:52');
INSERT INTO `tp_competence` VALUES ('108', '0', '操作日志管理', '', '0', '2017-08-15 09:26:33');
INSERT INTO `tp_competence` VALUES ('109', '0', '单页管理', '', '0', '2017-08-15 09:27:54');
INSERT INTO `tp_competence` VALUES ('110', '109', '单页列表', '', '0', '2017-08-15 09:29:06');
INSERT INTO `tp_competence` VALUES ('111', '0', 'IP封禁管理', '', '0', '2017-08-15 09:32:40');
INSERT INTO `tp_competence` VALUES ('112', '0', '分类管理', '', '0', '2017-08-15 09:34:10');
INSERT INTO `tp_competence` VALUES ('113', '0', '新闻柱形图统计', '', '0', '2017-08-15 09:36:01');
INSERT INTO `tp_competence` VALUES ('114', '0', '新闻饼状图统计', '', '0', '2017-08-15 09:36:23');
INSERT INTO `tp_competence` VALUES ('115', '109', '添加单页', '', '0', '2017-08-15 09:44:59');
INSERT INTO `tp_competence` VALUES ('116', '109', '修改单页', '', '0', '2017-08-15 09:45:08');
INSERT INTO `tp_competence` VALUES ('117', '109', '删除单页', '', '0', '2017-08-15 09:45:23');
INSERT INTO `tp_competence` VALUES ('118', '113', '查看', '', '0', '2017-08-15 10:05:09');
INSERT INTO `tp_competence` VALUES ('119', '114', '查看', '', '0', '2017-08-15 10:05:19');

-- ----------------------------
-- Table structure for `tp_contact`
-- ----------------------------
DROP TABLE IF EXISTS `tp_contact`;
CREATE TABLE `tp_contact` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Uid` int(10) DEFAULT '0' COMMENT '用户编号',
  `Cid` int(10) DEFAULT '0' COMMENT '客户档案编号',
  `ContactName` char(30) DEFAULT '' COMMENT '联系人',
  `Sex` char(4) DEFAULT NULL COMMENT '性别',
  `Post` tinyint(4) DEFAULT '0' COMMENT '职位',
  `Qq` char(30) DEFAULT NULL COMMENT '腾讯QQ',
  `Skype` char(30) DEFAULT NULL COMMENT 'msn',
  `Alww` char(30) DEFAULT '' COMMENT '阿里旺旺',
  `Phone` char(30) DEFAULT NULL COMMENT '手机',
  `Tel` char(20) DEFAULT NULL COMMENT '联系电话',
  `Fax` char(20) DEFAULT NULL COMMENT '传真',
  `Email` char(40) DEFAULT '' COMMENT '电子邮箱',
  `Birthday` datetime DEFAULT NULL COMMENT '生日',
  `Content` varchar(1000) DEFAULT NULL COMMENT '备注说明',
  `Recycle` tinyint(1) DEFAULT '0' COMMENT '是否在回收站',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  `FinalTime` datetime DEFAULT NULL COMMENT '最后更新',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_contact
-- ----------------------------
INSERT INTO `tp_contact` VALUES ('5', '1', '5', '开玩笑', '男', '22', '66666666', 'Skype@skype.com', 'lala.com', '15102041255', '445223115', '02066638783', 'qq@qq.com', '2014-01-07 19:40:38', null, '0', '2014-01-07 19:40:46', '2014-01-07 19:40:46');
INSERT INTO `tp_contact` VALUES ('6', '1', '6', '找小姐', '女', '23', '88888888', 'Skype@skype.com', 'lala.com', '1520335225', '445223115', '', 'qq@qq.com', '2014-01-07 19:42:15', null, '0', '2014-01-07 19:42:29', '2014-01-07 19:42:29');
INSERT INTO `tp_contact` VALUES ('15', '1', '1', '张三', '男', '22', '', '', '', '13100000000', '', '', '', '0000-00-00 00:00:00', null, '0', '2016-12-03 11:46:07', '2016-12-03 11:46:07');
INSERT INTO `tp_contact` VALUES ('16', '1', '15', '李四', '男', '22', '', '', '', '13400000000', '', '', '', '0000-00-00 00:00:00', null, '0', '2016-12-03 11:46:45', '2016-12-03 11:46:45');
INSERT INTO `tp_contact` VALUES ('17', '5', '16', '张三丰', '男', '22', '', '', '', '1380000000', '', '', '', '0000-00-00 00:00:00', null, '0', '2016-12-03 11:52:32', '2016-12-03 11:52:32');
INSERT INTO `tp_contact` VALUES ('18', '5', '17', '刘德华', '男', '22', '', '', '', '13700000000', '', '', '', '0000-00-00 00:00:00', null, '0', '2016-12-03 11:53:08', '2016-12-03 11:53:08');
INSERT INTO `tp_contact` VALUES ('19', '8', '18', '牛根生', '男', '22', '', '', '', '13900000000', '', '', '', '0000-00-00 00:00:00', null, '0', '2016-12-03 11:54:23', '2016-12-03 11:54:23');
INSERT INTO `tp_contact` VALUES ('20', '8', '19', '张小乐', '男', '22', '', '', '', '1391111111', '', '', '', '0000-00-00 00:00:00', null, '0', '2016-12-03 11:54:46', '2016-12-03 11:54:46');
INSERT INTO `tp_contact` VALUES ('21', '1', '20', 'wade', '', '0', 'wade', '', '', 'wade', 'wade', 'wade', 'wade', '0000-00-00 00:00:00', null, '0', '2017-01-04 16:48:53', '2017-01-04 16:48:53');
INSERT INTO `tp_contact` VALUES ('22', '1', '21', '5', '', '0', '6', '', '', '7', '8', '10', '9', '0000-00-00 00:00:00', null, '1', '2017-01-04 16:54:17', '2017-01-04 16:54:17');

-- ----------------------------
-- Table structure for `tp_dmenu`
-- ----------------------------
DROP TABLE IF EXISTS `tp_dmenu`;
CREATE TABLE `tp_dmenu` (
  `ID` int(5) unsigned NOT NULL AUTO_INCREMENT COMMENT 'ID编号',
  `Uid` int(8) DEFAULT NULL,
  `Sid` int(5) DEFAULT '0' COMMENT '下级ID',
  `MenuName` char(50) DEFAULT NULL COMMENT '下拉菜单名称',
  `Description` char(100) DEFAULT NULL COMMENT '描述',
  `Sortid` int(5) DEFAULT '0' COMMENT '序排ID',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=72 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_dmenu
-- ----------------------------
INSERT INTO `tp_dmenu` VALUES ('66', '1', '65', '中国仓库', '', '0', null);
INSERT INTO `tp_dmenu` VALUES ('67', '1', '65', '美国仓库', '', '0', null);
INSERT INTO `tp_dmenu` VALUES ('71', '1', '0', '11', '11', '0', null);

-- ----------------------------
-- Table structure for `tp_file`
-- ----------------------------
DROP TABLE IF EXISTS `tp_file`;
CREATE TABLE `tp_file` (
  `ID` int(10) NOT NULL AUTO_INCREMENT COMMENT '//ID编号',
  `Sid` int(8) DEFAULT '0' COMMENT '所属目录/分类',
  `Uid` int(10) DEFAULT '0' COMMENT '添加用户ID',
  `FileName` varchar(50) DEFAULT NULL COMMENT '文件/图片名称，可选',
  `Description` varchar(50) DEFAULT NULL COMMENT '文件/图片说明',
  `FilePath` varchar(100) DEFAULT NULL COMMENT '文件路径',
  `FileSize` int(10) DEFAULT '0' COMMENT '文件大小',
  `FileType` varchar(10) DEFAULT NULL COMMENT '文件类型',
  `Share` tinyint(1) DEFAULT '0' COMMENT '是否共享文件或图片',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_file
-- ----------------------------
INSERT INTO `tp_file` VALUES ('1', '0', '1', '1.txt', null, 'Uploads/Upload//1/20161127/583aac92954ca.txt', '85226', 'txt', '0', '2016-11-27 17:51:14');
INSERT INTO `tp_file` VALUES ('2', '0', '1', 'logo.png', null, 'Uploads/Picture/1/20161127/583aaca1bfc6c.png', '12134', 'png', '0', '2016-11-27 17:51:29');

-- ----------------------------
-- Table structure for `tp_fileclass`
-- ----------------------------
DROP TABLE IF EXISTS `tp_fileclass`;
CREATE TABLE `tp_fileclass` (
  `ID` int(8) unsigned NOT NULL AUTO_INCREMENT COMMENT '文件分类ID',
  `Sid` int(8) DEFAULT '0' COMMENT '分类SID',
  `Uid` int(8) DEFAULT '0' COMMENT '用户ID',
  `Sortid` int(5) DEFAULT '0' COMMENT '排序ID',
  `ClassName` varchar(20) DEFAULT NULL COMMENT '分类名称',
  `Description` varchar(50) DEFAULT NULL COMMENT '分类描述',
  `Status` tinyint(1) DEFAULT '0' COMMENT '状态',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_fileclass
-- ----------------------------
INSERT INTO `tp_fileclass` VALUES ('1', '0', '1', '0', '我的图片', '我的图片', '0', '2014-01-04 20:27:10');
INSERT INTO `tp_fileclass` VALUES ('2', '0', '1', '0', '我的文件', '', '0', '2014-01-04 20:27:20');
INSERT INTO `tp_fileclass` VALUES ('3', '0', '1', '0', 'ueidtor', '', '0', '2014-01-04 20:27:54');

-- ----------------------------
-- Table structure for `tp_goods`
-- ----------------------------
DROP TABLE IF EXISTS `tp_goods`;
CREATE TABLE `tp_goods` (
  `goods_id` int(11) NOT NULL AUTO_INCREMENT,
  `goods_sn` varchar(20) NOT NULL DEFAULT '' COMMENT '货号',
  `goods_name` varchar(60) NOT NULL DEFAULT '' COMMENT '商品名称',
  `price` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT '价格',
  `barcode` varchar(20) NOT NULL DEFAULT '' COMMENT '条码',
  `goods_image` varchar(60) NOT NULL DEFAULT '' COMMENT '商品主图',
  `create_time` int(11) NOT NULL DEFAULT '0' COMMENT '录入时间',
  PRIMARY KEY (`goods_id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_goods
-- ----------------------------
INSERT INTO `tp_goods` VALUES ('22', 'xiaomi1114', '小米手机44', '23.00', '111111144', '20170729/46d656471bcdba0fc7ea8104bd598f0a.jpg', '1501315682');

-- ----------------------------
-- Table structure for `tp_ip`
-- ----------------------------
DROP TABLE IF EXISTS `tp_ip`;
CREATE TABLE `tp_ip` (
  `ID` int(8) NOT NULL AUTO_INCREMENT COMMENT 'ID编号',
  `Uid` int(6) DEFAULT NULL COMMENT '操作用户',
  `Ip` varchar(50) DEFAULT NULL COMMENT '被封禁IP',
  `Description` varchar(50) DEFAULT NULL COMMENT '描述',
  `Status` tinyint(1) DEFAULT '0' COMMENT '是否永久封禁',
  `StartTime` date DEFAULT NULL COMMENT '开始日期',
  `EndTime` date DEFAULT NULL COMMENT '结束日期',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_ip
-- ----------------------------
INSERT INTO `tp_ip` VALUES ('5', '1', '202.20.1.0', '', '0', '2017-08-01', '2017-08-01', '2017-08-01 10:31:21');

-- ----------------------------
-- Table structure for `tp_link`
-- ----------------------------
DROP TABLE IF EXISTS `tp_link`;
CREATE TABLE `tp_link` (
  `link_id` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT '索引id',
  `link_title` varchar(100) DEFAULT NULL COMMENT '标题',
  `link_url` varchar(100) DEFAULT NULL COMMENT '链接',
  `link_pic` varchar(100) DEFAULT NULL COMMENT '图片',
  `link_sort` tinyint(3) unsigned NOT NULL DEFAULT '255' COMMENT '排序',
  PRIMARY KEY (`link_id`)
) ENGINE=MyISAM AUTO_INCREMENT=87 DEFAULT CHARSET=utf8 COMMENT='合作伙伴表';

-- ----------------------------
-- Records of tp_link
-- ----------------------------
INSERT INTO `tp_link` VALUES ('86', '121254', '1212', '20170724/8581cfc680afe7215472af4dc676836a.jpg', '255');
INSERT INTO `tp_link` VALUES ('85', '12123', '121212', '20170713/1651b235e824301faf84a17f6f0b839d.jpg', '255');
INSERT INTO `tp_link` VALUES ('83', '21', '1212', '20170713\\8182c094582aca9ab762082f8ac4465e.jpg', '255');
INSERT INTO `tp_link` VALUES ('84', '121212', '121212', '20170713/6cbf0afdb28194b5953936c7a2a3b61a.jpeg', '255');

-- ----------------------------
-- Table structure for `tp_loginlog`
-- ----------------------------
DROP TABLE IF EXISTS `tp_loginlog`;
CREATE TABLE `tp_loginlog` (
  `ID` int(10) NOT NULL AUTO_INCREMENT COMMENT 'ID编号',
  `Uid` int(8) DEFAULT NULL COMMENT '登录用户',
  `User` char(40) DEFAULT NULL COMMENT '户用名',
  `Description` varchar(40) DEFAULT NULL COMMENT '登录说明',
  `Area` char(20) DEFAULT NULL,
  `Loginip` varchar(30) DEFAULT NULL COMMENT '登录IP',
  `Dtime` datetime DEFAULT NULL COMMENT '登录时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=583 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_loginlog
-- ----------------------------
INSERT INTO `tp_loginlog` VALUES ('199', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-08 21:26:38');
INSERT INTO `tp_loginlog` VALUES ('200', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-08 21:37:02');
INSERT INTO `tp_loginlog` VALUES ('201', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-08 22:25:34');
INSERT INTO `tp_loginlog` VALUES ('202', '2', 'LITTLE', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-08 22:35:04');
INSERT INTO `tp_loginlog` VALUES ('203', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-08 22:37:50');
INSERT INTO `tp_loginlog` VALUES ('204', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-08 22:41:21');
INSERT INTO `tp_loginlog` VALUES ('205', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-09 21:07:00');
INSERT INTO `tp_loginlog` VALUES ('206', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-09 21:13:05');
INSERT INTO `tp_loginlog` VALUES ('207', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-09 21:15:24');
INSERT INTO `tp_loginlog` VALUES ('208', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-09 21:17:29');
INSERT INTO `tp_loginlog` VALUES ('209', '0', 'test', '<div class=\"de2\">用户不存在</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-13 21:13:03');
INSERT INTO `tp_loginlog` VALUES ('210', '0', 'test', '<div class=\"de2\">用户不存在</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-13 21:13:09');
INSERT INTO `tp_loginlog` VALUES ('211', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-13 21:13:16');
INSERT INTO `tp_loginlog` VALUES ('212', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-13 22:15:48');
INSERT INTO `tp_loginlog` VALUES ('213', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-21 20:44:55');
INSERT INTO `tp_loginlog` VALUES ('214', '1', 'admin', '<div class=\"de1\">登录成功</div>', '本机地址.IAMLE.COM', '127.0.0.1', '2014-01-21 21:36:11');
INSERT INTO `tp_loginlog` VALUES ('215', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 08:34:49');
INSERT INTO `tp_loginlog` VALUES ('216', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 10:33:53');
INSERT INTO `tp_loginlog` VALUES ('217', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 11:51:41');
INSERT INTO `tp_loginlog` VALUES ('218', '8', '小张', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 11:53:29');
INSERT INTO `tp_loginlog` VALUES ('219', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 11:55:04');
INSERT INTO `tp_loginlog` VALUES ('220', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 11:57:44');
INSERT INTO `tp_loginlog` VALUES ('221', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 11:58:18');
INSERT INTO `tp_loginlog` VALUES ('222', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:00:32');
INSERT INTO `tp_loginlog` VALUES ('223', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:01:28');
INSERT INTO `tp_loginlog` VALUES ('224', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:04:02');
INSERT INTO `tp_loginlog` VALUES ('225', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:04:24');
INSERT INTO `tp_loginlog` VALUES ('226', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:06:50');
INSERT INTO `tp_loginlog` VALUES ('227', '5', 'wade', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:07:15');
INSERT INTO `tp_loginlog` VALUES ('228', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2016-12-03 12:22:17');
INSERT INTO `tp_loginlog` VALUES ('229', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-01-04 16:37:11');
INSERT INTO `tp_loginlog` VALUES ('230', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-01-05 14:08:05');
INSERT INTO `tp_loginlog` VALUES ('231', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-01-14 09:00:24');
INSERT INTO `tp_loginlog` VALUES ('232', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-01-14 10:17:50');
INSERT INTO `tp_loginlog` VALUES ('233', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-01-21 10:21:53');
INSERT INTO `tp_loginlog` VALUES ('234', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-01-21 14:01:08');
INSERT INTO `tp_loginlog` VALUES ('235', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-03 09:48:16');
INSERT INTO `tp_loginlog` VALUES ('236', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 12:10:07');
INSERT INTO `tp_loginlog` VALUES ('237', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 12:12:49');
INSERT INTO `tp_loginlog` VALUES ('238', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 12:16:18');
INSERT INTO `tp_loginlog` VALUES ('239', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 14:16:36');
INSERT INTO `tp_loginlog` VALUES ('240', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 14:45:46');
INSERT INTO `tp_loginlog` VALUES ('241', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 14:53:38');
INSERT INTO `tp_loginlog` VALUES ('242', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 14:53:56');
INSERT INTO `tp_loginlog` VALUES ('243', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-14 16:41:03');
INSERT INTO `tp_loginlog` VALUES ('244', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-16 13:28:07');
INSERT INTO `tp_loginlog` VALUES ('245', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-16 14:17:42');
INSERT INTO `tp_loginlog` VALUES ('246', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-16 14:19:05');
INSERT INTO `tp_loginlog` VALUES ('247', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-16 17:38:08');
INSERT INTO `tp_loginlog` VALUES ('248', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-16 17:42:33');
INSERT INTO `tp_loginlog` VALUES ('249', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-18 09:51:23');
INSERT INTO `tp_loginlog` VALUES ('250', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-18 09:51:47');
INSERT INTO `tp_loginlog` VALUES ('251', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-18 13:45:05');
INSERT INTO `tp_loginlog` VALUES ('252', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-20 09:01:49');
INSERT INTO `tp_loginlog` VALUES ('253', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-20 09:47:56');
INSERT INTO `tp_loginlog` VALUES ('254', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-20 10:17:43');
INSERT INTO `tp_loginlog` VALUES ('255', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-20 15:02:31');
INSERT INTO `tp_loginlog` VALUES ('256', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-20 16:58:09');
INSERT INTO `tp_loginlog` VALUES ('257', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 08:27:13');
INSERT INTO `tp_loginlog` VALUES ('259', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 11:31:35');
INSERT INTO `tp_loginlog` VALUES ('260', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 13:34:38');
INSERT INTO `tp_loginlog` VALUES ('261', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 15:45:47');
INSERT INTO `tp_loginlog` VALUES ('262', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:21:59');
INSERT INTO `tp_loginlog` VALUES ('263', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:22:08');
INSERT INTO `tp_loginlog` VALUES ('264', null, '小张', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:26:54');
INSERT INTO `tp_loginlog` VALUES ('265', '8', '小张', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:27:04');
INSERT INTO `tp_loginlog` VALUES ('266', null, '小张', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:27:24');
INSERT INTO `tp_loginlog` VALUES ('267', '8', '小张', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:27:34');
INSERT INTO `tp_loginlog` VALUES ('268', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:34:24');
INSERT INTO `tp_loginlog` VALUES ('269', null, '小张', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:34:49');
INSERT INTO `tp_loginlog` VALUES ('270', '8', '小张', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:35:09');
INSERT INTO `tp_loginlog` VALUES ('271', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:39:41');
INSERT INTO `tp_loginlog` VALUES ('272', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:39:54');
INSERT INTO `tp_loginlog` VALUES ('273', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:41:19');
INSERT INTO `tp_loginlog` VALUES ('274', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 17:43:38');
INSERT INTO `tp_loginlog` VALUES ('275', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 20:38:31');
INSERT INTO `tp_loginlog` VALUES ('276', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 20:39:34');
INSERT INTO `tp_loginlog` VALUES ('277', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 20:39:42');
INSERT INTO `tp_loginlog` VALUES ('278', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 21:39:28');
INSERT INTO `tp_loginlog` VALUES ('279', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 21:39:32');
INSERT INTO `tp_loginlog` VALUES ('280', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-02-21 21:41:32');
INSERT INTO `tp_loginlog` VALUES ('281', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省.电信', '42.91.227.81', '2017-02-21 22:05:34');
INSERT INTO `tp_loginlog` VALUES ('282', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖北省武汉市.电信', '59.174.122.195', '2017-02-21 23:47:43');
INSERT INTO `tp_loginlog` VALUES ('283', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-22 08:22:41');
INSERT INTO `tp_loginlog` VALUES ('284', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-22 08:22:46');
INSERT INTO `tp_loginlog` VALUES ('318', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '四川省成都市双流县.电信', '125.71.66.245', '2017-02-26 18:43:23');
INSERT INTO `tp_loginlog` VALUES ('317', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '四川省成都市双流县.电信', '125.71.66.245', '2017-02-26 18:42:52');
INSERT INTO `tp_loginlog` VALUES ('288', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省湛江市.电信', '183.18.104.134', '2017-02-22 16:37:59');
INSERT INTO `tp_loginlog` VALUES ('316', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '四川省成都市双流县.电信', '125.71.66.245', '2017-02-26 18:42:46');
INSERT INTO `tp_loginlog` VALUES ('315', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '云南省.电信', '116.249.195.228', '2017-02-25 23:54:00');
INSERT INTO `tp_loginlog` VALUES ('314', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '云南省.电信', '116.249.195.228', '2017-02-25 23:53:47');
INSERT INTO `tp_loginlog` VALUES ('313', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '云南省.电信', '116.249.195.228', '2017-02-25 23:53:35');
INSERT INTO `tp_loginlog` VALUES ('312', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '云南省.电信', '116.249.195.228', '2017-02-25 23:53:22');
INSERT INTO `tp_loginlog` VALUES ('311', '1', 'admin', '<div class=\"de1\">登录成功</div>', '天津市.联通', '125.38.170.88', '2017-02-25 19:10:53');
INSERT INTO `tp_loginlog` VALUES ('310', '1', 'admin', '<div class=\"de1\">登录成功</div>', '上海市.长城宽带', '211.161.244.101', '2017-02-25 15:45:10');
INSERT INTO `tp_loginlog` VALUES ('308', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省广州市.电信', '113.66.106.251', '2017-02-24 00:40:12');
INSERT INTO `tp_loginlog` VALUES ('307', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省惠州市.电信', '113.83.231.32', '2017-02-23 16:23:31');
INSERT INTO `tp_loginlog` VALUES ('306', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省常州市.电信ADSL', '222.188.155.26', '2017-02-23 13:52:16');
INSERT INTO `tp_loginlog` VALUES ('305', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.263网络通信股份有限公司', '211.157.170.34', '2017-02-23 13:35:16');
INSERT INTO `tp_loginlog` VALUES ('304', '1', 'admin', '<div class=\"de1\">登录成功</div>', '内蒙古通辽市.电信', '1.180.235.246', '2017-02-23 13:34:24');
INSERT INTO `tp_loginlog` VALUES ('319', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '四川省成都市双流县.电信', '125.71.66.245', '2017-02-26 18:43:34');
INSERT INTO `tp_loginlog` VALUES ('320', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '四川省成都市双流县.电信', '125.71.66.245', '2017-02-26 18:46:50');
INSERT INTO `tp_loginlog` VALUES ('321', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '江苏省常州市.电信', '121.231.143.37', '2017-02-27 13:16:51');
INSERT INTO `tp_loginlog` VALUES ('322', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '江苏省常州市.电信', '121.231.143.37', '2017-02-27 13:17:15');
INSERT INTO `tp_loginlog` VALUES ('323', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '江苏省常州市.电信', '121.231.143.37', '2017-02-27 13:17:26');
INSERT INTO `tp_loginlog` VALUES ('324', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '江苏省常州市.电信', '121.231.143.37', '2017-02-27 13:17:37');
INSERT INTO `tp_loginlog` VALUES ('325', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-27 16:48:58');
INSERT INTO `tp_loginlog` VALUES ('326', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-27 16:49:07');
INSERT INTO `tp_loginlog` VALUES ('327', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-27 16:49:17');
INSERT INTO `tp_loginlog` VALUES ('328', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-27 16:50:40');
INSERT INTO `tp_loginlog` VALUES ('329', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖南省.电信', '223.146.250.57', '2017-02-27 17:32:22');
INSERT INTO `tp_loginlog` VALUES ('330', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-02-27 18:03:32');
INSERT INTO `tp_loginlog` VALUES ('331', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西柳州市.电信', '222.217.72.70', '2017-02-28 12:48:11');
INSERT INTO `tp_loginlog` VALUES ('332', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西柳州市.电信', '222.217.72.70', '2017-02-28 12:54:32');
INSERT INTO `tp_loginlog` VALUES ('333', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '60.164.26.184', '2017-03-01 22:54:43');
INSERT INTO `tp_loginlog` VALUES ('334', '1', 'admin', '<div class=\"de1\">登录成功</div>', '陕西省西安市.电信', '117.39.60.80', '2017-03-02 14:09:31');
INSERT INTO `tp_loginlog` VALUES ('335', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省广州市.电信', '113.66.104.184', '2017-03-02 15:26:31');
INSERT INTO `tp_loginlog` VALUES ('336', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.电信', '106.39.155.15', '2017-03-02 17:54:22');
INSERT INTO `tp_loginlog` VALUES ('337', '1', 'admin', '<div class=\"de1\">登录成功</div>', '加拿大.', '47.90.84.77', '2017-03-02 21:21:49');
INSERT INTO `tp_loginlog` VALUES ('338', '1', 'admin', '<div class=\"de1\">登录成功</div>', '台湾省.台北市', '60.245.23.136', '2017-03-03 01:25:02');
INSERT INTO `tp_loginlog` VALUES ('339', '1', 'admin', '<div class=\"de1\">登录成功</div>', '安徽省马鞍山市.电信', '36.57.130.211', '2017-03-03 09:07:09');
INSERT INTO `tp_loginlog` VALUES ('340', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-03 10:09:53');
INSERT INTO `tp_loginlog` VALUES ('341', '1', 'admin', '<div class=\"de1\">登录成功</div>', '重庆市.电信', '106.92.60.203', '2017-03-03 10:50:38');
INSERT INTO `tp_loginlog` VALUES ('342', '1', 'admin', '<div class=\"de1\">登录成功</div>', '四川省成都市.联通', '112.193.172.66', '2017-03-03 15:54:12');
INSERT INTO `tp_loginlog` VALUES ('343', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-03 16:35:01');
INSERT INTO `tp_loginlog` VALUES ('344', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省淄博市.联通', '112.227.90.185', '2017-03-03 17:41:26');
INSERT INTO `tp_loginlog` VALUES ('345', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省珠海市.电信', '14.116.17.254', '2017-03-05 13:28:55');
INSERT INTO `tp_loginlog` VALUES ('346', '1', 'admin', '<div class=\"de1\">登录成功</div>', '天津市.联通', '117.9.153.58', '2017-03-05 20:04:31');
INSERT INTO `tp_loginlog` VALUES ('347', '1', 'admin', '<div class=\"de1\">登录成功</div>', '海南省海口市.电信', '112.67.203.114', '2017-03-06 00:49:04');
INSERT INTO `tp_loginlog` VALUES ('348', '1', 'admin', '<div class=\"de1\">登录成功</div>', '辽宁省沈阳市.联通', '119.119.60.215', '2017-03-06 16:23:00');
INSERT INTO `tp_loginlog` VALUES ('349', '1', 'admin', '<div class=\"de1\">登录成功</div>', '四川省成都市.电信', '171.213.114.97', '2017-03-06 22:00:27');
INSERT INTO `tp_loginlog` VALUES ('350', '1', 'admin', '<div class=\"de1\">登录成功</div>', '辽宁省沈阳市.联通', '119.119.54.25', '2017-03-07 09:33:55');
INSERT INTO `tp_loginlog` VALUES ('351', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省广州市.电信', '113.68.109.163', '2017-03-07 09:34:54');
INSERT INTO `tp_loginlog` VALUES ('352', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-07 09:41:28');
INSERT INTO `tp_loginlog` VALUES ('353', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-07 13:49:08');
INSERT INTO `tp_loginlog` VALUES ('354', '0', 'test', '<div class=\"de2\">用户不存在</div>', '湖南省长沙市.电信', '113.218.21.76', '2017-03-07 15:18:49');
INSERT INTO `tp_loginlog` VALUES ('355', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖南省长沙市.电信', '113.218.21.76', '2017-03-07 15:19:02');
INSERT INTO `tp_loginlog` VALUES ('357', '1', 'admin', '<div class=\"de1\">登录成功</div>', '吉林省长春市.电信', '124.235.153.58', '2017-03-07 16:11:21');
INSERT INTO `tp_loginlog` VALUES ('358', '13', 'admin3', '<div class=\"de1\">登录成功</div>', '吉林省长春市.电信', '124.235.153.58', '2017-03-07 16:14:38');
INSERT INTO `tp_loginlog` VALUES ('359', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '吉林省长春市.电信', '124.235.153.58', '2017-03-07 16:15:39');
INSERT INTO `tp_loginlog` VALUES ('360', null, 'admin', '<div class=\"de2\">登录密码错误</div>', '吉林省长春市.电信', '124.235.153.58', '2017-03-07 16:15:47');
INSERT INTO `tp_loginlog` VALUES ('361', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省深圳市.电信', '183.14.170.95', '2017-03-07 16:21:14');
INSERT INTO `tp_loginlog` VALUES ('362', '1', 'admin', '<div class=\"de1\">登录成功</div>', '上海市.电信', '180.173.245.140', '2017-03-07 16:29:23');
INSERT INTO `tp_loginlog` VALUES ('363', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省广州市.电信', '113.68.110.210', '2017-03-07 16:31:12');
INSERT INTO `tp_loginlog` VALUES ('364', '1', 'admin', '<div class=\"de1\">登录成功</div>', '天津市.联通', '60.29.79.26', '2017-03-07 16:39:28');
INSERT INTO `tp_loginlog` VALUES ('365', '1', 'admin', '<div class=\"de1\">登录成功</div>', '上海市.电信', '222.72.189.146', '2017-03-07 16:58:02');
INSERT INTO `tp_loginlog` VALUES ('366', '1', 'admin', '<div class=\"de1\">登录成功</div>', '上海市.电信', '180.173.245.140', '2017-03-07 17:37:48');
INSERT INTO `tp_loginlog` VALUES ('367', '1', 'admin', '<div class=\"de1\">登录成功</div>', '陕西省咸阳市.电信', '113.142.234.132', '2017-03-07 19:53:08');
INSERT INTO `tp_loginlog` VALUES ('368', '1', 'admin', '<div class=\"de1\">登录成功</div>', '福建省福州市.电信', '117.29.202.69', '2017-03-07 22:06:09');
INSERT INTO `tp_loginlog` VALUES ('369', '14', '334455', '<div class=\"de1\">登录成功</div>', '福建省福州市.电信', '117.29.202.69', '2017-03-07 22:07:21');
INSERT INTO `tp_loginlog` VALUES ('370', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖南省长沙市.电信', '113.218.21.76', '2017-03-08 08:31:56');
INSERT INTO `tp_loginlog` VALUES ('371', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '180.140.162.0', '2017-03-08 12:29:12');
INSERT INTO `tp_loginlog` VALUES ('372', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '180.140.162.0', '2017-03-08 12:30:22');
INSERT INTO `tp_loginlog` VALUES ('373', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '113.12.166.232', '2017-03-08 12:55:38');
INSERT INTO `tp_loginlog` VALUES ('374', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '113.12.167.157', '2017-03-08 14:10:58');
INSERT INTO `tp_loginlog` VALUES ('375', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '113.12.167.157', '2017-03-08 14:17:05');
INSERT INTO `tp_loginlog` VALUES ('376', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '113.12.166.232', '2017-03-08 14:17:11');
INSERT INTO `tp_loginlog` VALUES ('377', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-08 16:03:28');
INSERT INTO `tp_loginlog` VALUES ('378', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '113.12.166.232', '2017-03-08 16:09:42');
INSERT INTO `tp_loginlog` VALUES ('379', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '113.12.166.232', '2017-03-08 16:12:21');
INSERT INTO `tp_loginlog` VALUES ('380', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-08 17:11:25');
INSERT INTO `tp_loginlog` VALUES ('381', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-08 17:24:16');
INSERT INTO `tp_loginlog` VALUES ('382', '1', 'admin', '<div class=\"de1\">登录成功</div>', '上海市.联通', '140.206.97.42', '2017-03-08 19:01:50');
INSERT INTO `tp_loginlog` VALUES ('383', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '180.140.162.0', '2017-03-09 08:15:40');
INSERT INTO `tp_loginlog` VALUES ('384', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-09 08:46:31');
INSERT INTO `tp_loginlog` VALUES ('385', '1', 'admin', '<div class=\"de1\">登录成功</div>', '新疆.电信', '49.118.241.59', '2017-03-09 08:48:33');
INSERT INTO `tp_loginlog` VALUES ('386', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-09 09:37:46');
INSERT INTO `tp_loginlog` VALUES ('387', '1', 'admin', '<div class=\"de1\">登录成功</div>', '新疆.电信', '49.118.241.59', '2017-03-09 12:28:17');
INSERT INTO `tp_loginlog` VALUES ('388', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省青岛市.联通', '112.224.67.60', '2017-03-09 12:30:21');
INSERT INTO `tp_loginlog` VALUES ('389', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-09 13:29:53');
INSERT INTO `tp_loginlog` VALUES ('390', '1', 'admin', '<div class=\"de1\">登录成功</div>', '新疆.电信', '49.118.241.59', '2017-03-09 13:33:40');
INSERT INTO `tp_loginlog` VALUES ('391', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-10 08:57:09');
INSERT INTO `tp_loginlog` VALUES ('392', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西百色市.电信', '218.65.219.186', '2017-03-10 09:16:02');
INSERT INTO `tp_loginlog` VALUES ('393', '1', 'admin', '<div class=\"de1\">登录成功</div>', '浙江省宁波市.电信', '115.238.180.58', '2017-03-10 09:25:30');
INSERT INTO `tp_loginlog` VALUES ('394', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-10 10:14:50');
INSERT INTO `tp_loginlog` VALUES ('395', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-10 14:23:42');
INSERT INTO `tp_loginlog` VALUES ('396', '1', 'admin', '<div class=\"de1\">登录成功</div>', '天津市.联通', '117.9.153.58', '2017-03-10 21:37:06');
INSERT INTO `tp_loginlog` VALUES ('397', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省临沂市.联通', '123.132.226.66', '2017-03-11 17:26:49');
INSERT INTO `tp_loginlog` VALUES ('398', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.宽带通', '223.21.130.55', '2017-03-11 23:01:00');
INSERT INTO `tp_loginlog` VALUES ('399', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.宽带通', '223.21.130.55', '2017-03-11 23:09:26');
INSERT INTO `tp_loginlog` VALUES ('400', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖北省武汉市.长城宽带', '49.210.144.20', '2017-03-12 11:23:44');
INSERT INTO `tp_loginlog` VALUES ('401', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省佛山市南海区.电信', '116.20.61.1', '2017-03-12 22:59:10');
INSERT INTO `tp_loginlog` VALUES ('402', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省临沂市.联通', '27.218.142.148', '2017-03-13 09:43:53');
INSERT INTO `tp_loginlog` VALUES ('403', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.电信CDMA', '115.171.94.54', '2017-03-13 14:45:16');
INSERT INTO `tp_loginlog` VALUES ('404', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省临沂市.联通', '27.218.142.148', '2017-03-13 17:27:43');
INSERT INTO `tp_loginlog` VALUES ('405', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西南宁市.电信', '116.9.90.133', '2017-03-13 19:01:16');
INSERT INTO `tp_loginlog` VALUES ('406', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信', '27.227.234.173', '2017-03-13 21:37:35');
INSERT INTO `tp_loginlog` VALUES ('407', '1', 'admin', '<div class=\"de1\">登录成功</div>', '天津市.联通', '117.9.27.132', '2017-03-13 21:40:29');
INSERT INTO `tp_loginlog` VALUES ('408', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省.移动', '183.206.172.11', '2017-03-13 23:21:55');
INSERT INTO `tp_loginlog` VALUES ('409', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-14 08:49:09');
INSERT INTO `tp_loginlog` VALUES ('410', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-14 08:58:18');
INSERT INTO `tp_loginlog` VALUES ('411', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-14 08:59:26');
INSERT INTO `tp_loginlog` VALUES ('412', '1', 'admin', '<div class=\"de1\">登录成功</div>', '浙江省台州市.电信', '60.162.115.158', '2017-03-14 13:18:23');
INSERT INTO `tp_loginlog` VALUES ('413', '1', 'admin', '<div class=\"de1\">登录成功</div>', '浙江省台州市.电信', '60.162.115.158', '2017-03-14 13:24:05');
INSERT INTO `tp_loginlog` VALUES ('414', '1', 'admin', '<div class=\"de1\">登录成功</div>', '浙江省台州市.电信', '60.162.115.158', '2017-03-14 13:24:08');
INSERT INTO `tp_loginlog` VALUES ('415', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省广州市.电信', '119.130.208.207', '2017-03-14 15:38:32');
INSERT INTO `tp_loginlog` VALUES ('416', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省.移动', '112.28.142.39', '2017-03-14 19:21:41');
INSERT INTO `tp_loginlog` VALUES ('417', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省.移动', '112.28.142.39', '2017-03-14 19:32:51');
INSERT INTO `tp_loginlog` VALUES ('418', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省苏州市.电信ADSL', '58.208.39.7', '2017-03-14 19:37:10');
INSERT INTO `tp_loginlog` VALUES ('419', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省.移动', '112.28.142.39', '2017-03-14 19:39:33');
INSERT INTO `tp_loginlog` VALUES ('420', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省青岛市.电信', '182.40.187.97', '2017-03-14 20:21:12');
INSERT INTO `tp_loginlog` VALUES ('421', '1', 'admin', '<div class=\"de1\">登录成功</div>', '新疆乌鲁木齐市.移动', '120.205.222.8', '2017-03-15 00:53:25');
INSERT INTO `tp_loginlog` VALUES ('422', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-15 10:28:03');
INSERT INTO `tp_loginlog` VALUES ('423', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广东省深圳市.电信', '183.39.152.146', '2017-03-15 11:20:08');
INSERT INTO `tp_loginlog` VALUES ('424', '1', 'admin', '<div class=\"de1\">登录成功</div>', '山东省青岛市.长城宽带', '42.199.131.232', '2017-03-15 11:20:28');
INSERT INTO `tp_loginlog` VALUES ('425', '1', 'admin', '<div class=\"de1\">登录成功</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:38:40');
INSERT INTO `tp_loginlog` VALUES ('426', '15', 'hailinhd', '<div class=\"de1\">登录成功</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:46:43');
INSERT INTO `tp_loginlog` VALUES ('427', null, 'hailinhd', '<div class=\"de2\">登录密码错误</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:48:26');
INSERT INTO `tp_loginlog` VALUES ('428', null, 'hailinhd', '<div class=\"de2\">登录密码错误</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:48:39');
INSERT INTO `tp_loginlog` VALUES ('429', null, 'hailinhd', '<div class=\"de2\">登录密码错误</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:48:52');
INSERT INTO `tp_loginlog` VALUES ('430', null, 'hailinhd', '<div class=\"de2\">登录密码错误</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:49:03');
INSERT INTO `tp_loginlog` VALUES ('431', '15', 'hailinhd', '<div class=\"de1\">登录成功</div>', '新疆乌鲁木齐市.电信', '110.152.25.101', '2017-03-15 12:49:21');
INSERT INTO `tp_loginlog` VALUES ('432', '1', 'admin', '<div class=\"de1\">登录成功</div>', '广西百色市.电信', '218.65.219.186', '2017-03-15 14:44:06');
INSERT INTO `tp_loginlog` VALUES ('433', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.联通', '111.207.12.110', '2017-03-15 17:07:27');
INSERT INTO `tp_loginlog` VALUES ('434', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-16 09:08:40');
INSERT INTO `tp_loginlog` VALUES ('435', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.铁通', '122.70.189.90', '2017-03-16 14:36:52');
INSERT INTO `tp_loginlog` VALUES ('436', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖北省武汉市.电信', '58.48.166.166', '2017-03-16 16:10:42');
INSERT INTO `tp_loginlog` VALUES ('437', '1', 'admin', '<div class=\"de1\">登录成功</div>', '浙江省杭州市.移动', '39.190.219.236', '2017-03-16 22:01:39');
INSERT INTO `tp_loginlog` VALUES ('438', '1', 'admin', '<div class=\"de1\">登录成功</div>', '四川省成都市.电信', '222.210.175.110', '2017-03-16 22:55:52');
INSERT INTO `tp_loginlog` VALUES ('439', '1', 'admin', '<div class=\"de1\">登录成功</div>', '辽宁省沈阳市.电信', '182.200.43.117', '2017-03-17 12:40:49');
INSERT INTO `tp_loginlog` VALUES ('440', '1', 'admin', '<div class=\"de1\">登录成功</div>', '上海市.电信', '116.226.151.167', '2017-03-17 17:20:17');
INSERT INTO `tp_loginlog` VALUES ('441', '1', 'admin', '<div class=\"de1\">登录成功</div>', '河南省郑州市.电信', '171.8.107.99', '2017-03-17 18:08:32');
INSERT INTO `tp_loginlog` VALUES ('442', '1', 'admin', '<div class=\"de1\">登录成功</div>', '湖北省咸宁市.电信', '111.179.32.184', '2017-03-17 18:28:01');
INSERT INTO `tp_loginlog` VALUES ('443', '1', 'admin', '<div class=\"de1\">登录成功</div>', '北京市.电信', '1.202.111.129', '2017-03-17 20:11:26');
INSERT INTO `tp_loginlog` VALUES ('444', '1', 'admin', '<div class=\"de1\">登录成功</div>', '云南省玉溪市.电信', '222.220.205.48', '2017-03-18 09:48:07');
INSERT INTO `tp_loginlog` VALUES ('445', '1', 'admin', '<div class=\"de1\">登录成功</div>', '甘肃省兰州市.电信ADSL', '61.178.84.19', '2017-03-18 09:50:22');
INSERT INTO `tp_loginlog` VALUES ('446', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省泰州市.联通', '112.83.136.28', '2017-03-18 14:15:42');
INSERT INTO `tp_loginlog` VALUES ('447', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省泰州市.联通', '112.83.136.28', '2017-03-18 14:15:42');
INSERT INTO `tp_loginlog` VALUES ('448', '1', 'admin', '<div class=\"de1\">登录成功</div>', '江苏省泰州市.联通', '112.83.136.28', '2017-03-18 14:24:02');
INSERT INTO `tp_loginlog` VALUES ('449', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-04-24 15:50:23');
INSERT INTO `tp_loginlog` VALUES ('450', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-04-25 09:53:20');
INSERT INTO `tp_loginlog` VALUES ('451', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-05-12 14:51:28');
INSERT INTO `tp_loginlog` VALUES ('452', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-05-13 15:44:30');
INSERT INTO `tp_loginlog` VALUES ('453', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-05-22 14:35:28');
INSERT INTO `tp_loginlog` VALUES ('454', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-05-22 14:40:59');
INSERT INTO `tp_loginlog` VALUES ('455', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-07 11:59:14');
INSERT INTO `tp_loginlog` VALUES ('456', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-07 12:11:02');
INSERT INTO `tp_loginlog` VALUES ('457', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-07 13:17:04');
INSERT INTO `tp_loginlog` VALUES ('458', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-07 18:27:36');
INSERT INTO `tp_loginlog` VALUES ('459', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-20 15:45:15');
INSERT INTO `tp_loginlog` VALUES ('460', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-27 17:35:49');
INSERT INTO `tp_loginlog` VALUES ('461', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-27 17:37:26');
INSERT INTO `tp_loginlog` VALUES ('462', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-27 17:37:44');
INSERT INTO `tp_loginlog` VALUES ('463', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-27 17:38:53');
INSERT INTO `tp_loginlog` VALUES ('464', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-28 17:51:26');
INSERT INTO `tp_loginlog` VALUES ('465', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-06-29 09:28:57');
INSERT INTO `tp_loginlog` VALUES ('466', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-04 13:53:45');
INSERT INTO `tp_loginlog` VALUES ('467', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-04 14:16:05');
INSERT INTO `tp_loginlog` VALUES ('468', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-04 16:57:30');
INSERT INTO `tp_loginlog` VALUES ('469', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-05 09:48:15');
INSERT INTO `tp_loginlog` VALUES ('470', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-05 14:01:58');
INSERT INTO `tp_loginlog` VALUES ('471', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-05 14:10:36');
INSERT INTO `tp_loginlog` VALUES ('472', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-05 15:44:25');
INSERT INTO `tp_loginlog` VALUES ('473', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 10:20:53');
INSERT INTO `tp_loginlog` VALUES ('474', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 10:23:07');
INSERT INTO `tp_loginlog` VALUES ('475', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 12:09:50');
INSERT INTO `tp_loginlog` VALUES ('476', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 13:58:05');
INSERT INTO `tp_loginlog` VALUES ('477', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 14:04:32');
INSERT INTO `tp_loginlog` VALUES ('478', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 15:34:45');
INSERT INTO `tp_loginlog` VALUES ('479', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-08 15:48:08');
INSERT INTO `tp_loginlog` VALUES ('480', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-11 08:24:18');
INSERT INTO `tp_loginlog` VALUES ('481', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-11 08:58:08');
INSERT INTO `tp_loginlog` VALUES ('482', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-11 08:59:24');
INSERT INTO `tp_loginlog` VALUES ('483', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-11 13:58:32');
INSERT INTO `tp_loginlog` VALUES ('484', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-11 17:20:14');
INSERT INTO `tp_loginlog` VALUES ('485', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-11 18:06:29');
INSERT INTO `tp_loginlog` VALUES ('486', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 10:56:59');
INSERT INTO `tp_loginlog` VALUES ('487', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:04:44');
INSERT INTO `tp_loginlog` VALUES ('488', '0', 'wyh', '<div class=\"de2\">用户不存在</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:49:35');
INSERT INTO `tp_loginlog` VALUES ('489', '17', 'why', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:49:54');
INSERT INTO `tp_loginlog` VALUES ('490', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:50:35');
INSERT INTO `tp_loginlog` VALUES ('491', null, 'why', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:51:39');
INSERT INTO `tp_loginlog` VALUES ('492', null, 'why', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:51:48');
INSERT INTO `tp_loginlog` VALUES ('493', null, 'why', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:51:56');
INSERT INTO `tp_loginlog` VALUES ('494', null, 'why', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:52:05');
INSERT INTO `tp_loginlog` VALUES ('495', null, 'why', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:52:39');
INSERT INTO `tp_loginlog` VALUES ('496', '17', 'why', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:52:48');
INSERT INTO `tp_loginlog` VALUES ('497', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 11:58:32');
INSERT INTO `tp_loginlog` VALUES ('498', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 17:07:54');
INSERT INTO `tp_loginlog` VALUES ('499', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-12 17:15:55');
INSERT INTO `tp_loginlog` VALUES ('500', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-13 08:54:34');
INSERT INTO `tp_loginlog` VALUES ('501', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-13 09:00:33');
INSERT INTO `tp_loginlog` VALUES ('502', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-19 15:46:01');
INSERT INTO `tp_loginlog` VALUES ('503', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-22 11:03:56');
INSERT INTO `tp_loginlog` VALUES ('504', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-22 11:11:55');
INSERT INTO `tp_loginlog` VALUES ('505', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-22 11:16:44');
INSERT INTO `tp_loginlog` VALUES ('506', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-24 09:03:32');
INSERT INTO `tp_loginlog` VALUES ('507', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-24 09:15:45');
INSERT INTO `tp_loginlog` VALUES ('508', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-24 11:57:01');
INSERT INTO `tp_loginlog` VALUES ('509', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-24 13:47:39');
INSERT INTO `tp_loginlog` VALUES ('510', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-24 15:06:26');
INSERT INTO `tp_loginlog` VALUES ('511', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-24 17:48:09');
INSERT INTO `tp_loginlog` VALUES ('512', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-25 09:04:44');
INSERT INTO `tp_loginlog` VALUES ('513', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-29 10:51:53');
INSERT INTO `tp_loginlog` VALUES ('514', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-29 12:03:07');
INSERT INTO `tp_loginlog` VALUES ('515', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-29 14:40:33');
INSERT INTO `tp_loginlog` VALUES ('516', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-29 15:43:48');
INSERT INTO `tp_loginlog` VALUES ('517', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-31 09:33:35');
INSERT INTO `tp_loginlog` VALUES ('518', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-31 10:01:49');
INSERT INTO `tp_loginlog` VALUES ('519', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-31 10:26:43');
INSERT INTO `tp_loginlog` VALUES ('520', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-31 11:17:27');
INSERT INTO `tp_loginlog` VALUES ('521', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-31 14:18:03');
INSERT INTO `tp_loginlog` VALUES ('522', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-07-31 14:22:33');
INSERT INTO `tp_loginlog` VALUES ('523', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-01 10:30:44');
INSERT INTO `tp_loginlog` VALUES ('524', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-01 10:32:54');
INSERT INTO `tp_loginlog` VALUES ('525', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-01 10:41:16');
INSERT INTO `tp_loginlog` VALUES ('526', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-01 15:01:20');
INSERT INTO `tp_loginlog` VALUES ('527', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-14 16:13:38');
INSERT INTO `tp_loginlog` VALUES ('528', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-14 16:28:28');
INSERT INTO `tp_loginlog` VALUES ('529', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 08:46:41');
INSERT INTO `tp_loginlog` VALUES ('530', null, 'qqq', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:11:36');
INSERT INTO `tp_loginlog` VALUES ('531', null, 'qqq', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:11:45');
INSERT INTO `tp_loginlog` VALUES ('532', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:12:25');
INSERT INTO `tp_loginlog` VALUES ('533', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:21:48');
INSERT INTO `tp_loginlog` VALUES ('534', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:56:07');
INSERT INTO `tp_loginlog` VALUES ('535', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:56:16');
INSERT INTO `tp_loginlog` VALUES ('536', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:56:34');
INSERT INTO `tp_loginlog` VALUES ('537', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 09:59:14');
INSERT INTO `tp_loginlog` VALUES ('538', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:01:17');
INSERT INTO `tp_loginlog` VALUES ('539', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:10:06');
INSERT INTO `tp_loginlog` VALUES ('540', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:13:00');
INSERT INTO `tp_loginlog` VALUES ('541', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:13:44');
INSERT INTO `tp_loginlog` VALUES ('542', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:26:14');
INSERT INTO `tp_loginlog` VALUES ('543', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:28:37');
INSERT INTO `tp_loginlog` VALUES ('544', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:32:45');
INSERT INTO `tp_loginlog` VALUES ('545', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:33:13');
INSERT INTO `tp_loginlog` VALUES ('546', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:53:37');
INSERT INTO `tp_loginlog` VALUES ('547', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:55:27');
INSERT INTO `tp_loginlog` VALUES ('548', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:57:49');
INSERT INTO `tp_loginlog` VALUES ('549', '19', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:58:24');
INSERT INTO `tp_loginlog` VALUES ('550', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:58:38');
INSERT INTO `tp_loginlog` VALUES ('551', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 10:58:58');
INSERT INTO `tp_loginlog` VALUES ('552', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 11:55:57');
INSERT INTO `tp_loginlog` VALUES ('553', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 11:56:12');
INSERT INTO `tp_loginlog` VALUES ('554', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 13:44:41');
INSERT INTO `tp_loginlog` VALUES ('555', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 13:45:03');
INSERT INTO `tp_loginlog` VALUES ('556', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 16:47:39');
INSERT INTO `tp_loginlog` VALUES ('557', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-15 16:48:06');
INSERT INTO `tp_loginlog` VALUES ('558', null, 'admin', '<div class=\"de2\">登录密码错误</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-16 14:33:31');
INSERT INTO `tp_loginlog` VALUES ('559', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-16 14:33:47');
INSERT INTO `tp_loginlog` VALUES ('560', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 09:48:46');
INSERT INTO `tp_loginlog` VALUES ('561', '0', 'qqq', '<div class=\"de2\">用户不存在</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 10:08:24');
INSERT INTO `tp_loginlog` VALUES ('562', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 10:08:33');
INSERT INTO `tp_loginlog` VALUES ('563', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 10:10:25');
INSERT INTO `tp_loginlog` VALUES ('564', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 10:17:54');
INSERT INTO `tp_loginlog` VALUES ('565', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 10:18:31');
INSERT INTO `tp_loginlog` VALUES ('566', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-19 15:06:19');
INSERT INTO `tp_loginlog` VALUES ('567', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:28:56');
INSERT INTO `tp_loginlog` VALUES ('568', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:42:30');
INSERT INTO `tp_loginlog` VALUES ('569', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:43:01');
INSERT INTO `tp_loginlog` VALUES ('570', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:43:44');
INSERT INTO `tp_loginlog` VALUES ('571', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:44:49');
INSERT INTO `tp_loginlog` VALUES ('572', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:45:34');
INSERT INTO `tp_loginlog` VALUES ('573', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:50:41');
INSERT INTO `tp_loginlog` VALUES ('574', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:54:06');
INSERT INTO `tp_loginlog` VALUES ('575', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:54:45');
INSERT INTO `tp_loginlog` VALUES ('576', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:56:55');
INSERT INTO `tp_loginlog` VALUES ('577', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:57:26');
INSERT INTO `tp_loginlog` VALUES ('578', '24', 'qqq', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-08-30 16:58:27');
INSERT INTO `tp_loginlog` VALUES ('579', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-09-02 16:07:14');
INSERT INTO `tp_loginlog` VALUES ('580', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-09-05 11:21:33');
INSERT INTO `tp_loginlog` VALUES ('581', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-09-08 14:23:38');
INSERT INTO `tp_loginlog` VALUES ('582', '1', 'admin', '<div class=\"de1\">登录成功</div>', 'IANA保留地址.', '0.0.0.0', '2017-09-08 17:20:38');

-- ----------------------------
-- Table structure for `tp_module`
-- ----------------------------
DROP TABLE IF EXISTS `tp_module`;
CREATE TABLE `tp_module` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Sid` int(5) DEFAULT '0' COMMENT '下级分类',
  `Uid` int(10) DEFAULT '0' COMMENT '操作用户ID',
  `ModuleName` varchar(20) DEFAULT NULL COMMENT '模块名称',
  `ModuleImg` varchar(50) DEFAULT NULL COMMENT '菜单图标',
  `ModuleUrl` varchar(50) DEFAULT NULL COMMENT '连接地址',
  `Status` tinyint(4) DEFAULT '0' COMMENT '态状',
  `Description` varchar(50) DEFAULT NULL COMMENT '描述',
  `Msort` int(5) DEFAULT '0' COMMENT '序排ID',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  `Competence` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_module
-- ----------------------------
INSERT INTO `tp_module` VALUES ('1', '0', '1', '用户管理', '1', 'User/index', '0', '', '1', '2013-12-15 17:12:34', '1');
INSERT INTO `tp_module` VALUES ('2', '0', '1', '系统管理', '2', 'System/module', '0', '', '1', '2013-12-15 17:13:50', '16');
INSERT INTO `tp_module` VALUES ('3', '0', '1', '日志管理', '3', 'Loginlog/index', '0', '', '2', '2013-12-15 17:14:05', '17');
INSERT INTO `tp_module` VALUES ('4', '1', '1', '用户管理', '4', 'User/index', '0', '', '0', '2013-12-15 17:15:09', '1');
INSERT INTO `tp_module` VALUES ('5', '1', '1', '角色管理', '5', 'Role/index', '0', '', '1', '2013-12-15 17:15:54', '6');
INSERT INTO `tp_module` VALUES ('6', '1', '1', '权限列表', '6', 'Competence/index', '0', '', '2', '2013-12-15 17:18:00', '11');
INSERT INTO `tp_module` VALUES ('7', '2', '1', '模块管理', '7', 'System/module', '0', '', '2', '2013-12-15 17:18:37', '106');
INSERT INTO `tp_module` VALUES ('8', '2', '1', '封禁IP', '8', 'System/ip', '0', '', '3', '2013-12-15 17:20:22', '111');
INSERT INTO `tp_module` VALUES ('15', '0', '1', '新闻动态', '15', 'News/classindex', '0', '', '4', '2013-12-25 14:48:17', '44');
INSERT INTO `tp_module` VALUES ('16', '15', '1', '栏目分类', '16', 'News/classindex', '0', '', '0', '2013-12-25 14:51:07', '112');
INSERT INTO `tp_module` VALUES ('17', '15', '1', '发布文章', '17', 'News/add', '0', '', '1', '2013-12-25 14:51:47', '44');
INSERT INTO `tp_module` VALUES ('18', '15', '1', '新闻列表', '18', 'News/news', '0', '', '2', '2013-12-25 14:52:17', '44');
INSERT INTO `tp_module` VALUES ('25', '2', '1', '下拉菜单', '25', 'Dmenu/index', '0', '', '4', '2013-12-29 20:51:03', '59');
INSERT INTO `tp_module` VALUES ('26', '3', '1', '登录日志', '26', 'Loginlog/index', '0', '', '0', '2013-12-29 22:38:08', '107');
INSERT INTO `tp_module` VALUES ('27', '3', '1', '操作日志', '27', 'Operating/index', '0', '', '1', '2013-12-29 22:39:53', '108');
INSERT INTO `tp_module` VALUES ('29', '0', '1', '管理首页', '/Public/image/home/img/22.png', 'Index/content', '0', '', '0', '2014-01-03 22:12:51', '');
INSERT INTO `tp_module` VALUES ('38', '0', '0', '统计报表', '38', 'Report/news', '0', '', '20', null, '');
INSERT INTO `tp_module` VALUES ('39', '38', '0', '新闻柱形图统计', '39', 'Report/news', '0', '', '0', null, '113');
INSERT INTO `tp_module` VALUES ('40', '38', '0', '新闻饼状图统计', '40', 'Report/pie', '0', '', '3', null, '114');
INSERT INTO `tp_module` VALUES ('43', '2', '0', '友情链接', '43', 'Link/index', '0', '', '10', null, '91');
INSERT INTO `tp_module` VALUES ('44', '2', '0', '广告管理', '44', 'Advertisement/index', '0', '', '18', null, '96');
INSERT INTO `tp_module` VALUES ('45', '15', '0', '单页管理', '45', 'Page/index', '0', '', '35', null, '109');
INSERT INTO `tp_module` VALUES ('46', '0', '0', '商品管理', '46', 'Goods/index', '0', '', '15', null, '101');
INSERT INTO `tp_module` VALUES ('47', '46', '0', '商品管理', '47', 'Goods/index', '0', '', '0', null, '101');
INSERT INTO `tp_module` VALUES ('48', '29', '0', '首页', 'undefined', 'index/content', '0', '', '0', null, '');
INSERT INTO `tp_module` VALUES ('51', '15', '0', '留言管理', 'undefined', 'Question/index', '0', '', '36', null, '0');

-- ----------------------------
-- Table structure for `tp_news`
-- ----------------------------
DROP TABLE IF EXISTS `tp_news`;
CREATE TABLE `tp_news` (
  `ID` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Sid` int(6) DEFAULT '0' COMMENT '分类ID',
  `Uid` int(6) DEFAULT '0' COMMENT '用户ID',
  `Title` char(80) DEFAULT NULL COMMENT '标题',
  `Description` char(200) DEFAULT NULL COMMENT '描述',
  `Content` text COMMENT '内容',
  `Sortid` int(6) DEFAULT '0' COMMENT '排序ID',
  `View` int(6) DEFAULT '0' COMMENT '读阅数',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  `image` varchar(60) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_news
-- ----------------------------
INSERT INTO `tp_news` VALUES ('18', '4', '0', '上海季后赛门票价格出炉：最低100元', '', '<p style=\"font: 14px/24px \">体育2月21日讯 2016-17赛季CBA季后赛将于2月24日正式开战，排名第三的上海队将在季后赛首轮迎战深圳队。目前，上海男篮主场季后赛门票票价已经出炉，最低价为100元。</p><p style=\"font: 14px/24px \">根据季后赛首轮1-2-1-1赛制安排，上海队将在2月24日在客场迎来与深圳队的首场对决，2月26日、3月1日将在主场对阵深圳。若有需要，上海队将与3月3日前往深圳客场，3月5日的比赛将回到主场在浦东源深体育中心举行。</p><p style=\"font: 14px/24px \">季后赛上海主场票价分为五档，一档票580元、二档票380元、三档票280元、四档票180元、五档票100元。</p><p><br/></p>', '2', '13', '2017-09-08 15:09:43', '');
INSERT INTO `tp_news` VALUES ('20', '2', '0', '111', '111', '<p>34333333333</p><pre class=\"brush:php;toolbar:false\">&lt;?php\r\necho&nbsp;&quot;cccc&quot;;\r\n?&gt;</pre><p><br/></p>', '3', '5', null, '');
INSERT INTO `tp_news` VALUES ('23', '4', '0', '11111111', '111111111111111', '<p>&lt;?php</p><p>echo 1;</p><p>?&gt;</p><p>山东省地方是对方</p>', '3', '13', null, '');
INSERT INTO `tp_news` VALUES ('24', '4', '0', '34', '343434', '<p>&lt;?php echo 1;?&gt;</p><p><br/></p><p>地方的辅导费</p>', '4', '5', null, '');
INSERT INTO `tp_news` VALUES ('25', '4', '0', '12323', '232323', '<p>&lt;?php echo 111;?&gt;</p><p><br/></p><p>山东省地方是对方<br/></p>', '5', '5', null, '');
INSERT INTO `tp_news` VALUES ('26', '4', '0', '234234', '232323', '<p>&lt;?php echo &quot;ccc&quot;;?&gt;</p><p><br/></p><p>aasas <br/></p>', '6', '8', null, '');
INSERT INTO `tp_news` VALUES ('27', '4', '0', 'dcdd', 'ddd', '<pre class=\"brush:php;toolbar:false\">echo&nbsp;1;</pre><p><br/></p>', '7', '10', null, '');
INSERT INTO `tp_news` VALUES ('28', '4', '0', '1', '1', '<p>1</p>', '8', '6', null, '20170902/452fbca6aacd73a828ec827c9f4addbb.jpg');
INSERT INTO `tp_news` VALUES ('29', '7', '0', '111111111', '11111', '<p>11111111111111111111111111</p>', '9', '6', null, '20170908/e9f620ef57fd07fba6d403c5d16ff13c.jpg');
INSERT INTO `tp_news` VALUES ('30', '0', '0', null, null, null, '0', '2', null, '');
INSERT INTO `tp_news` VALUES ('31', '0', '0', null, null, null, '0', '1', null, '');
INSERT INTO `tp_news` VALUES ('32', '0', '0', null, null, null, '0', '0', null, '');
INSERT INTO `tp_news` VALUES ('33', '0', '0', null, null, null, '0', '0', null, '');
INSERT INTO `tp_news` VALUES ('34', '0', '0', null, null, null, '0', '1', null, '');
INSERT INTO `tp_news` VALUES ('35', '0', '0', null, null, null, '0', '1', null, '');
INSERT INTO `tp_news` VALUES ('36', '0', '0', null, null, null, '0', '1', null, '');
INSERT INTO `tp_news` VALUES ('37', '0', '0', null, null, null, '0', '1', null, '');
INSERT INTO `tp_news` VALUES ('38', '0', '0', null, null, null, '0', '1', null, '');
INSERT INTO `tp_news` VALUES ('39', '0', '0', null, null, null, '0', '0', null, '');
INSERT INTO `tp_news` VALUES ('40', '0', '0', null, null, null, '0', '0', null, '');
INSERT INTO `tp_news` VALUES ('41', '0', '0', null, null, null, '0', '0', null, '');
INSERT INTO `tp_news` VALUES ('42', '0', '0', null, null, null, '0', '0', null, '');
INSERT INTO `tp_news` VALUES ('43', '0', '0', null, null, null, '0', '0', null, '');

-- ----------------------------
-- Table structure for `tp_newsclass`
-- ----------------------------
DROP TABLE IF EXISTS `tp_newsclass`;
CREATE TABLE `tp_newsclass` (
  `ID` int(5) unsigned NOT NULL AUTO_INCREMENT,
  `Sid` int(5) DEFAULT '0' COMMENT '下级分类（预留）',
  `Uid` int(8) DEFAULT '0' COMMENT '用户ID',
  `ClassName` char(20) DEFAULT NULL COMMENT '分类名称',
  `Description` char(30) DEFAULT NULL COMMENT '描述',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_newsclass
-- ----------------------------
INSERT INTO `tp_newsclass` VALUES ('2', '0', '1', '娱乐新闻', '娱乐新闻', '2013-12-25 16:23:53');
INSERT INTO `tp_newsclass` VALUES ('4', '0', '0', '财经新闻', '财经新闻', null);
INSERT INTO `tp_newsclass` VALUES ('7', '0', '0', '案例展示', '', null);

-- ----------------------------
-- Table structure for `tp_operating`
-- ----------------------------
DROP TABLE IF EXISTS `tp_operating`;
CREATE TABLE `tp_operating` (
  `ID` int(8) unsigned NOT NULL AUTO_INCREMENT,
  `Uid` int(8) DEFAULT '0',
  `Url` varchar(300) DEFAULT NULL COMMENT '操作块模URL',
  `Description` varchar(300) DEFAULT NULL COMMENT '说明',
  `Ip` char(60) DEFAULT NULL COMMENT '操作IP',
  `Status` tinyint(4) DEFAULT '0' COMMENT '状态,1代表成功2代表失败',
  `Dtime` datetime DEFAULT NULL COMMENT '发生时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=734 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_operating
-- ----------------------------
INSERT INTO `tp_operating` VALUES ('4', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-05 13:26:40');
INSERT INTO `tp_operating` VALUES ('23', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 13:32:17');
INSERT INTO `tp_operating` VALUES ('29', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 13:54:23');
INSERT INTO `tp_operating` VALUES ('30', '1', '/OA/index.php/File/fileindel', '删除成功', '127.0.0.1', '0', '2014-01-05 13:55:23');
INSERT INTO `tp_operating` VALUES ('31', '1', '/OA/index.php/System/module_edit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 13:56:14');
INSERT INTO `tp_operating` VALUES ('32', '1', '/OA/index.php/User/useredit_do', '更改用户资料：小峰', '127.0.0.1', '0', '2014-01-05 14:32:04');
INSERT INTO `tp_operating` VALUES ('33', '1', '/OA/index.php/User/useredit_do', '更改用户资料：小峰', '127.0.0.1', '0', '2014-01-05 14:34:10');
INSERT INTO `tp_operating` VALUES ('34', '1', '/OA/index.php/User/useredit_do', '更改用户资料：小峰', '127.0.0.1', '0', '2014-01-05 14:34:14');
INSERT INTO `tp_operating` VALUES ('35', '1', '/OA/index.php/Competence/cadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 14:35:00');
INSERT INTO `tp_operating` VALUES ('36', '1', '/OA/index.php/Competence/cadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 14:35:12');
INSERT INTO `tp_operating` VALUES ('37', '1', '/OA/index.php/Role/roleedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 14:35:50');
INSERT INTO `tp_operating` VALUES ('38', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 14:48:00');
INSERT INTO `tp_operating` VALUES ('39', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 14:54:05');
INSERT INTO `tp_operating` VALUES ('40', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 14:54:11');
INSERT INTO `tp_operating` VALUES ('41', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 14:54:55');
INSERT INTO `tp_operating` VALUES ('42', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 14:57:41');
INSERT INTO `tp_operating` VALUES ('43', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 15:12:45');
INSERT INTO `tp_operating` VALUES ('44', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 15:13:00');
INSERT INTO `tp_operating` VALUES ('45', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 15:13:08');
INSERT INTO `tp_operating` VALUES ('46', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 15:13:13');
INSERT INTO `tp_operating` VALUES ('47', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 15:28:27');
INSERT INTO `tp_operating` VALUES ('48', '1', '/OA/index.php/System/module_edit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 15:32:26');
INSERT INTO `tp_operating` VALUES ('49', '1', '/OA/index.php/System/systemconfig_do', '系统配置修改成功', '127.0.0.1', '0', '2014-01-05 15:39:34');
INSERT INTO `tp_operating` VALUES ('50', '1', '/OA/index.php/System/module_edit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 16:00:20');
INSERT INTO `tp_operating` VALUES ('51', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 16:00:27');
INSERT INTO `tp_operating` VALUES ('52', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 16:03:45');
INSERT INTO `tp_operating` VALUES ('53', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 16:03:56');
INSERT INTO `tp_operating` VALUES ('54', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:05:07');
INSERT INTO `tp_operating` VALUES ('55', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:05:22');
INSERT INTO `tp_operating` VALUES ('56', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:05:32');
INSERT INTO `tp_operating` VALUES ('57', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:05:42');
INSERT INTO `tp_operating` VALUES ('58', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:05:54');
INSERT INTO `tp_operating` VALUES ('59', '1', '/OA/index.php/With/withadd_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:06:07');
INSERT INTO `tp_operating` VALUES ('60', '1', '/OA/index.php/System/systemconfig_do', '系统配置修改成功', '127.0.0.1', '0', '2014-01-05 16:33:30');
INSERT INTO `tp_operating` VALUES ('61', '1', '/OA/index.php/News/add_do', '新增失败标题请在80个字符以内！', '127.0.0.1', '1', '2014-01-05 16:45:36');
INSERT INTO `tp_operating` VALUES ('62', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:46:41');
INSERT INTO `tp_operating` VALUES ('63', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:48:00');
INSERT INTO `tp_operating` VALUES ('64', '1', '/OA/index.php/News/edit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 16:48:45');
INSERT INTO `tp_operating` VALUES ('65', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:50:11');
INSERT INTO `tp_operating` VALUES ('66', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:51:50');
INSERT INTO `tp_operating` VALUES ('67', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:52:34');
INSERT INTO `tp_operating` VALUES ('68', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:53:25');
INSERT INTO `tp_operating` VALUES ('69', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:54:43');
INSERT INTO `tp_operating` VALUES ('70', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:55:54');
INSERT INTO `tp_operating` VALUES ('71', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:56:56');
INSERT INTO `tp_operating` VALUES ('72', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:58:04');
INSERT INTO `tp_operating` VALUES ('73', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-05 16:59:24');
INSERT INTO `tp_operating` VALUES ('74', '1', '/OA/index.php/System/module_edit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 17:07:28');
INSERT INTO `tp_operating` VALUES ('75', '1', '/OA/index.php/System/module_edit_do', '更新成功', '127.0.0.1', '0', '2014-01-05 17:07:42');
INSERT INTO `tp_operating` VALUES ('76', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 17:07:51');
INSERT INTO `tp_operating` VALUES ('77', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-05 19:34:29');
INSERT INTO `tp_operating` VALUES ('78', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-06 00:19:59');
INSERT INTO `tp_operating` VALUES ('79', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-06 00:23:40');
INSERT INTO `tp_operating` VALUES ('80', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-06 00:31:33');
INSERT INTO `tp_operating` VALUES ('81', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-06 00:38:37');
INSERT INTO `tp_operating` VALUES ('82', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-06 22:21:22');
INSERT INTO `tp_operating` VALUES ('83', '1', '/OA/index.php/User/in_user_del', '批量删除ID为：4,3的数据', '127.0.0.1', '0', '2014-01-07 20:47:05');
INSERT INTO `tp_operating` VALUES ('84', '1', '/OA/index.php/News/add_do', '新增成功', '127.0.0.1', '0', '2014-01-08 21:28:30');
INSERT INTO `tp_operating` VALUES ('85', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:28:39');
INSERT INTO `tp_operating` VALUES ('86', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:31:51');
INSERT INTO `tp_operating` VALUES ('87', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:33:23');
INSERT INTO `tp_operating` VALUES ('88', '1', '/OA/index.php/Upload/filedo', '上传成功', '127.0.0.1', '0', '2014-01-08 21:40:11');
INSERT INTO `tp_operating` VALUES ('89', '1', '/OA/index.php/File/filedel', '删除成功', '127.0.0.1', '0', '2014-01-08 21:40:24');
INSERT INTO `tp_operating` VALUES ('90', '1', '/OA/index.php/File/fileindel', '删除成功', '127.0.0.1', '0', '2014-01-08 21:48:14');
INSERT INTO `tp_operating` VALUES ('91', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:49:06');
INSERT INTO `tp_operating` VALUES ('92', '1', '/OA/index.php/System/systemcore_do', '核心配置文件修改成功', '127.0.0.1', '0', '2014-01-08 21:56:14');
INSERT INTO `tp_operating` VALUES ('93', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:56:20');
INSERT INTO `tp_operating` VALUES ('94', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:57:00');
INSERT INTO `tp_operating` VALUES ('95', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-08 21:57:31');
INSERT INTO `tp_operating` VALUES ('96', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:36:29');
INSERT INTO `tp_operating` VALUES ('97', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:36:52');
INSERT INTO `tp_operating` VALUES ('98', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:37:04');
INSERT INTO `tp_operating` VALUES ('99', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:39:24');
INSERT INTO `tp_operating` VALUES ('100', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:39:56');
INSERT INTO `tp_operating` VALUES ('101', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:40:22');
INSERT INTO `tp_operating` VALUES ('102', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-08 23:40:51');
INSERT INTO `tp_operating` VALUES ('104', '1', '/OA/index.php/System/systemconfig_do', '系统配置修改成功', '127.0.0.1', '0', '2014-01-09 21:13:47');
INSERT INTO `tp_operating` VALUES ('105', '1', '/OA/index.php/System/systemconfig_do', '系统配置修改成功', '127.0.0.1', '0', '2014-01-09 21:14:31');
INSERT INTO `tp_operating` VALUES ('106', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-09 21:16:33');
INSERT INTO `tp_operating` VALUES ('107', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-09 21:16:37');
INSERT INTO `tp_operating` VALUES ('108', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-13 22:30:49');
INSERT INTO `tp_operating` VALUES ('109', '1', '/OA/index.php/With/withedit_do', '更新成功', '127.0.0.1', '0', '2014-01-13 22:30:52');
INSERT INTO `tp_operating` VALUES ('110', '1', '/OA/index.php/User/useredit_do', '更改用户资料：admin', '127.0.0.1', '0', '2014-01-21 21:07:12');
INSERT INTO `tp_operating` VALUES ('111', '1', '/OA/index.php/Competence/cedit_do', '更新成功', '127.0.0.1', '0', '2014-01-21 21:08:31');
INSERT INTO `tp_operating` VALUES ('112', '1', '/OA/index.php/System/systemconfig_do', '系统配置修改成功', '127.0.0.1', '0', '2014-01-21 21:15:45');
INSERT INTO `tp_operating` VALUES ('113', '1', '/OA/index.php/Competence/cedit_do', '更新成功', '127.0.0.1', '0', '2014-01-21 21:21:26');
INSERT INTO `tp_operating` VALUES ('114', '1', '/OA/index.php/Competence/cadd_do', '新增成功', '127.0.0.1', '0', '2014-01-21 21:22:26');
INSERT INTO `tp_operating` VALUES ('115', '1', '/OA/index.php/Competence/cedit_do', '更新成功', '127.0.0.1', '0', '2014-01-21 21:23:58');
INSERT INTO `tp_operating` VALUES ('116', '1', '/OA/index.php/Competence/cadd_do', '新增成功', '127.0.0.1', '0', '2014-01-21 21:25:27');
INSERT INTO `tp_operating` VALUES ('117', '1', '/OA/index.php/Common/clearcache', '清空站点缓存', '127.0.0.1', '0', '2014-01-21 21:34:10');
INSERT INTO `tp_operating` VALUES ('118', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:26');
INSERT INTO `tp_operating` VALUES ('119', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:30');
INSERT INTO `tp_operating` VALUES ('120', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:34');
INSERT INTO `tp_operating` VALUES ('121', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:37');
INSERT INTO `tp_operating` VALUES ('122', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:41');
INSERT INTO `tp_operating` VALUES ('123', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:44');
INSERT INTO `tp_operating` VALUES ('124', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:47');
INSERT INTO `tp_operating` VALUES ('125', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:50');
INSERT INTO `tp_operating` VALUES ('126', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:53');
INSERT INTO `tp_operating` VALUES ('127', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:34:56');
INSERT INTO `tp_operating` VALUES ('128', '1', '/OA/index.php/Loginlog/indel', '登录日志删除成功', '127.0.0.1', '0', '2014-01-21 21:35:02');
INSERT INTO `tp_operating` VALUES ('129', '1', '/OA/index.php/User/useredit_do', '更改用户资料：admin', '127.0.0.1', '0', '2014-01-21 21:35:43');
INSERT INTO `tp_operating` VALUES ('130', '1', '/OA/index.php/User/useredit_do', '更改用户资料：admin', '127.0.0.1', '0', '2014-01-21 21:35:52');
INSERT INTO `tp_operating` VALUES ('355', '1', 'admin/loginlog/del', '登录日志删除成功', '180.173.245.140', '0', '2017-03-07 15:40:01');
INSERT INTO `tp_operating` VALUES ('132', '1', '/crm/index.php/Common/clearcache', '清空站点缓存', '0.0.0.0', '0', '2016-11-27 17:31:58');
INSERT INTO `tp_operating` VALUES ('133', '1', '/crm/index.php/System/systemcore_do', '核心配置文件修改成功', '0.0.0.0', '0', '2016-11-27 17:50:27');
INSERT INTO `tp_operating` VALUES ('134', '1', '/crm/index.php/Upload/filedo', '上传成功', '0.0.0.0', '0', '2016-11-27 17:51:14');
INSERT INTO `tp_operating` VALUES ('135', '1', '/crm/index.php/Upload/picdo', '上传成功', '0.0.0.0', '0', '2016-11-27 17:51:29');
INSERT INTO `tp_operating` VALUES ('136', '1', '/crm/index.php/User/useredit_do', '更改用户资料：admin1', '0.0.0.0', '0', '2016-12-03 08:46:16');
INSERT INTO `tp_operating` VALUES ('137', '1', '/crm/index.php/User/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2016-12-03 08:46:25');
INSERT INTO `tp_operating` VALUES ('138', '1', '/crm/index.php/Role/roleedit_do', '更新成功', '0.0.0.0', '0', '2016-12-03 08:48:02');
INSERT INTO `tp_operating` VALUES ('139', '1', '/crm/index.php/User/useredit_do', '更改用户资料：wade', '0.0.0.0', '0', '2016-12-03 08:48:28');
INSERT INTO `tp_operating` VALUES ('140', '1', '/crm/index.php/User/useradd_do', '新增用户：小张', '0.0.0.0', '0', '2016-12-03 09:01:26');
INSERT INTO `tp_operating` VALUES ('141', '1', '/crm/index.php/User/useradd_do', '新增用户：122', '0.0.0.0', '0', '2016-12-03 10:34:22');
INSERT INTO `tp_operating` VALUES ('142', '1', '/crm/index.php/User/userdel', '删除用户ID为：7的数据', '0.0.0.0', '0', '2016-12-03 10:35:01');
INSERT INTO `tp_operating` VALUES ('143', '1', '/crm/index.php/User/userdel', '删除用户ID为：6的数据', '0.0.0.0', '0', '2016-12-03 10:35:05');
INSERT INTO `tp_operating` VALUES ('144', '1', '/crm/index.php/User/useradd_do', '新增用户：小张', '0.0.0.0', '0', '2016-12-03 10:35:21');
INSERT INTO `tp_operating` VALUES ('145', '1', '/crm/index.php/User/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2016-12-03 10:43:56');
INSERT INTO `tp_operating` VALUES ('146', '1', '/crm/index.php/User/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2016-12-03 10:44:46');
INSERT INTO `tp_operating` VALUES ('147', '1', '/crm/index.php/User/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2016-12-03 10:46:58');
INSERT INTO `tp_operating` VALUES ('148', '1', '/crm/index.php/User/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2016-12-03 10:47:06');
INSERT INTO `tp_operating` VALUES ('149', '1', '/crm/index.php/Client/clientadd_do', '新增客户：华为admin', '0.0.0.0', '0', '2016-12-03 11:46:07');
INSERT INTO `tp_operating` VALUES ('150', '1', '/crm/index.php/Client/clientadd_do', '新增客户：小米admin', '0.0.0.0', '0', '2016-12-03 11:46:45');
INSERT INTO `tp_operating` VALUES ('151', '1', '/crm/index.php/Role/roledel', '删除成功', '0.0.0.0', '0', '2016-12-03 11:47:08');
INSERT INTO `tp_operating` VALUES ('152', '1', '/crm/index.php/Role/roleedit_do', '更新成功', '0.0.0.0', '0', '2016-12-03 11:50:07');
INSERT INTO `tp_operating` VALUES ('153', '1', '/crm/index.php/User/useredit_do', '更改用户资料：wade', '0.0.0.0', '0', '2016-12-03 11:50:22');
INSERT INTO `tp_operating` VALUES ('154', '1', '/crm/index.php/User/useredit_do', '更改用户资料：wade', '0.0.0.0', '0', '2016-12-03 11:50:42');
INSERT INTO `tp_operating` VALUES ('155', '1', '/crm/index.php/User/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2016-12-03 11:51:29');
INSERT INTO `tp_operating` VALUES ('156', '5', '/crm/index.php/Client/clientadd_do', '新增客户：特步wade', '0.0.0.0', '0', '2016-12-03 11:52:32');
INSERT INTO `tp_operating` VALUES ('157', '5', '/crm/index.php/Client/clientadd_do', '新增客户：李宁wade', '0.0.0.0', '0', '2016-12-03 11:53:08');
INSERT INTO `tp_operating` VALUES ('158', '8', '/crm/index.php/Client/clientadd_do', '新增客户：蒙牛小张', '0.0.0.0', '0', '2016-12-03 11:54:23');
INSERT INTO `tp_operating` VALUES ('159', '8', '/crm/index.php/Client/clientadd_do', '新增客户：伊利小张', '0.0.0.0', '0', '2016-12-03 11:54:46');
INSERT INTO `tp_operating` VALUES ('160', '5', '/crm/index.php/Client/clientedit', '没有找到数据：19', '0.0.0.0', '1', '2016-12-03 12:07:28');
INSERT INTO `tp_operating` VALUES ('161', '1', '/crm/wap.php/Client/clientadd_do', '新增客户：wade', '0.0.0.0', '0', '2017-01-04 16:48:53');
INSERT INTO `tp_operating` VALUES ('162', '1', '/crm/wap.php/Client/clientadd_do', '新增客户：1', '0.0.0.0', '0', '2017-01-04 16:54:17');
INSERT INTO `tp_operating` VALUES ('163', '1', '/crm/index.php/Client/client_del', '删除成功：21', '0.0.0.0', '0', '2017-01-14 10:18:06');
INSERT INTO `tp_operating` VALUES ('164', '1', '/crm/index.php/System/systemcore_do', '核心配置文件修改成功', '0.0.0.0', '0', '2017-01-21 10:22:45');
INSERT INTO `tp_operating` VALUES ('165', '1', '/crm/index.php/System/systemcore_do', '核心配置文件修改成功', '0.0.0.0', '0', '2017-01-21 10:23:19');
INSERT INTO `tp_operating` VALUES ('166', '1', '/crm/index.php/Common/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-01-21 10:23:45');
INSERT INTO `tp_operating` VALUES ('167', '1', '/crm/index.php/System/systemcore_do', '核心配置文件修改成功', '0.0.0.0', '0', '2017-01-21 10:52:12');
INSERT INTO `tp_operating` VALUES ('168', '1', '/crm/index.php/System/systemcore_do', '核心配置文件修改成功', '0.0.0.0', '0', '2017-01-21 10:52:20');
INSERT INTO `tp_operating` VALUES ('169', '1', '/crm/index.php/System/systemcore_do', '核心配置文件修改成功', '0.0.0.0', '0', '2017-01-21 10:52:25');
INSERT INTO `tp_operating` VALUES ('170', '1', 'admin/user/useredit_do', '更改用户资料：LITTLE', '0.0.0.0', '0', '2017-02-20 09:48:39');
INSERT INTO `tp_operating` VALUES ('171', '1', 'admin/user/useredit_do', '更改用户资料：LITTLE', '0.0.0.0', '0', '2017-02-20 09:49:54');
INSERT INTO `tp_operating` VALUES ('172', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-02-20 10:45:41');
INSERT INTO `tp_operating` VALUES ('173', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-02-20 10:52:04');
INSERT INTO `tp_operating` VALUES ('174', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-20 11:03:38');
INSERT INTO `tp_operating` VALUES ('175', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-20 11:03:43');
INSERT INTO `tp_operating` VALUES ('176', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-02-20 11:04:34');
INSERT INTO `tp_operating` VALUES ('177', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:13:38');
INSERT INTO `tp_operating` VALUES ('178', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:13:43');
INSERT INTO `tp_operating` VALUES ('179', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:14:19');
INSERT INTO `tp_operating` VALUES ('180', '1', 'admin/competence/cedit_do', '更新失败', '0.0.0.0', '1', '2017-02-20 11:14:32');
INSERT INTO `tp_operating` VALUES ('181', '1', 'admin/competence/cedit_do', '更新失败', '0.0.0.0', '1', '2017-02-20 11:14:36');
INSERT INTO `tp_operating` VALUES ('182', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:14:41');
INSERT INTO `tp_operating` VALUES ('183', '1', 'admin/competence/cedit_do', '更新失败', '0.0.0.0', '1', '2017-02-20 11:24:37');
INSERT INTO `tp_operating` VALUES ('184', '1', 'admin/competence/cedit_do', '更新失败', '0.0.0.0', '1', '2017-02-20 11:24:39');
INSERT INTO `tp_operating` VALUES ('185', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-20 11:24:43');
INSERT INTO `tp_operating` VALUES ('186', '1', 'admin/user/useredit_do', '更新失败：LITTLE', '0.0.0.0', '1', '2017-02-20 11:25:18');
INSERT INTO `tp_operating` VALUES ('187', '1', 'admin/user/useredit_do', '更新失败：LITTLE', '0.0.0.0', '1', '2017-02-20 11:25:21');
INSERT INTO `tp_operating` VALUES ('188', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:32:09');
INSERT INTO `tp_operating` VALUES ('189', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:32:18');
INSERT INTO `tp_operating` VALUES ('190', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-20 11:32:25');
INSERT INTO `tp_operating` VALUES ('191', '1', 'admin/role/roleadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 08:51:49');
INSERT INTO `tp_operating` VALUES ('192', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 08:53:21');
INSERT INTO `tp_operating` VALUES ('193', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 08:54:16');
INSERT INTO `tp_operating` VALUES ('194', '1', 'admin/role/roleedit', '参数错误', '0.0.0.0', '1', '2017-02-21 08:54:17');
INSERT INTO `tp_operating` VALUES ('195', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 08:54:56');
INSERT INTO `tp_operating` VALUES ('196', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 08:56:53');
INSERT INTO `tp_operating` VALUES ('197', '1', 'admin/user/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2017-02-21 08:57:30');
INSERT INTO `tp_operating` VALUES ('198', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 08:58:22');
INSERT INTO `tp_operating` VALUES ('199', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 08:58:27');
INSERT INTO `tp_operating` VALUES ('200', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 08:59:11');
INSERT INTO `tp_operating` VALUES ('201', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:01:05');
INSERT INTO `tp_operating` VALUES ('202', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:01:10');
INSERT INTO `tp_operating` VALUES ('203', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:02:45');
INSERT INTO `tp_operating` VALUES ('204', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:04:13');
INSERT INTO `tp_operating` VALUES ('205', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:05:11');
INSERT INTO `tp_operating` VALUES ('206', '1', 'admin/user/useredit_do', '更新失败：小张', '0.0.0.0', '1', '2017-02-21 09:05:16');
INSERT INTO `tp_operating` VALUES ('207', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:06:25');
INSERT INTO `tp_operating` VALUES ('208', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 09:07:10');
INSERT INTO `tp_operating` VALUES ('209', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:07:15');
INSERT INTO `tp_operating` VALUES ('210', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:07:32');
INSERT INTO `tp_operating` VALUES ('211', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:08:18');
INSERT INTO `tp_operating` VALUES ('212', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:08:28');
INSERT INTO `tp_operating` VALUES ('213', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:10:48');
INSERT INTO `tp_operating` VALUES ('214', '1', 'admin/user/useredit_do', '更新失败：小张', '0.0.0.0', '1', '2017-02-21 09:11:49');
INSERT INTO `tp_operating` VALUES ('215', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 09:27:33');
INSERT INTO `tp_operating` VALUES ('216', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:30:52');
INSERT INTO `tp_operating` VALUES ('217', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:31:01');
INSERT INTO `tp_operating` VALUES ('218', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:37:09');
INSERT INTO `tp_operating` VALUES ('219', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:38:33');
INSERT INTO `tp_operating` VALUES ('220', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:38:53');
INSERT INTO `tp_operating` VALUES ('221', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 09:39:40');
INSERT INTO `tp_operating` VALUES ('222', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 09:41:31');
INSERT INTO `tp_operating` VALUES ('223', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 09:43:36');
INSERT INTO `tp_operating` VALUES ('224', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 09:43:42');
INSERT INTO `tp_operating` VALUES ('225', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 09:43:52');
INSERT INTO `tp_operating` VALUES ('226', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 09:43:58');
INSERT INTO `tp_operating` VALUES ('228', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-02-21 10:24:16');
INSERT INTO `tp_operating` VALUES ('229', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-02-21 10:25:00');
INSERT INTO `tp_operating` VALUES ('230', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 10:25:04');
INSERT INTO `tp_operating` VALUES ('231', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 10:25:08');
INSERT INTO `tp_operating` VALUES ('232', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 10:40:42');
INSERT INTO `tp_operating` VALUES ('233', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 10:40:48');
INSERT INTO `tp_operating` VALUES ('234', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 10:40:53');
INSERT INTO `tp_operating` VALUES ('235', '1', 'admin/system/ipadd_do', '新增IP限制登录成功', '0.0.0.0', '0', '2017-02-21 10:48:42');
INSERT INTO `tp_operating` VALUES ('236', '1', 'admin/system/del', '删除成功', '0.0.0.0', '0', '2017-02-21 10:53:05');
INSERT INTO `tp_operating` VALUES ('237', '1', 'admin/system/del', '删除成功', '0.0.0.0', '0', '2017-02-21 10:53:09');
INSERT INTO `tp_operating` VALUES ('238', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 10:59:50');
INSERT INTO `tp_operating` VALUES ('239', '1', 'admin/dmenu/dmenuedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:00:01');
INSERT INTO `tp_operating` VALUES ('240', '1', 'admin/dmenu/del', '删除成功', '0.0.0.0', '0', '2017-02-21 11:02:46');
INSERT INTO `tp_operating` VALUES ('241', '1', 'admin/news/classadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 11:09:29');
INSERT INTO `tp_operating` VALUES ('242', '1', 'admin/news/classdel', '删除成功', '0.0.0.0', '0', '2017-02-21 11:10:17');
INSERT INTO `tp_operating` VALUES ('243', '1', 'admin/news/classedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:11:38');
INSERT INTO `tp_operating` VALUES ('244', '1', 'admin/news/classedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:11:44');
INSERT INTO `tp_operating` VALUES ('245', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-02-21 11:11:54');
INSERT INTO `tp_operating` VALUES ('246', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:17:09');
INSERT INTO `tp_operating` VALUES ('247', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:17:13');
INSERT INTO `tp_operating` VALUES ('248', '1', 'admin/news/edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:22:25');
INSERT INTO `tp_operating` VALUES ('249', '1', 'admin/news/edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 11:22:37');
INSERT INTO `tp_operating` VALUES ('250', '1', 'admin/news/newsdel', '删除成功', '0.0.0.0', '0', '2017-02-21 11:23:54');
INSERT INTO `tp_operating` VALUES ('251', '1', 'admin/news/newsdel', '删除成功', '0.0.0.0', '0', '2017-02-21 11:23:57');
INSERT INTO `tp_operating` VALUES ('252', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-02-21 11:52:27');
INSERT INTO `tp_operating` VALUES ('253', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-02-21 11:53:08');
INSERT INTO `tp_operating` VALUES ('254', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-02-21 13:36:13');
INSERT INTO `tp_operating` VALUES ('255', '1', 'admin/news/edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 13:36:53');
INSERT INTO `tp_operating` VALUES ('256', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:48:46');
INSERT INTO `tp_operating` VALUES ('257', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:48:52');
INSERT INTO `tp_operating` VALUES ('258', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:48:56');
INSERT INTO `tp_operating` VALUES ('259', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 14:49:39');
INSERT INTO `tp_operating` VALUES ('260', '1', 'admin/user/userdel', '删除用户ID为：2的数据', '0.0.0.0', '0', '2017-02-21 14:49:54');
INSERT INTO `tp_operating` VALUES ('261', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:52:19');
INSERT INTO `tp_operating` VALUES ('262', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:52:25');
INSERT INTO `tp_operating` VALUES ('263', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:52:29');
INSERT INTO `tp_operating` VALUES ('264', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:53:27');
INSERT INTO `tp_operating` VALUES ('265', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:53:32');
INSERT INTO `tp_operating` VALUES ('266', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-02-21 14:53:36');
INSERT INTO `tp_operating` VALUES ('267', '1', 'admin/role/roledel', '删除成功', '0.0.0.0', '0', '2017-02-21 14:55:43');
INSERT INTO `tp_operating` VALUES ('268', '1', 'admin/news/newsdel', '删除成功', '0.0.0.0', '0', '2017-02-21 15:46:07');
INSERT INTO `tp_operating` VALUES ('269', '1', 'admin/news/newsdel', '删除成功', '0.0.0.0', '0', '2017-02-21 15:46:10');
INSERT INTO `tp_operating` VALUES ('270', '1', 'admin/news/newsdel', '删除成功', '0.0.0.0', '0', '2017-02-21 15:47:22');
INSERT INTO `tp_operating` VALUES ('271', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-02-21 15:47:55');
INSERT INTO `tp_operating` VALUES ('272', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-02-21 17:12:56');
INSERT INTO `tp_operating` VALUES ('273', '1', 'admin/user/uedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 17:15:17');
INSERT INTO `tp_operating` VALUES ('274', '1', 'admin/user/uedit_do', '修改密码成功', '0.0.0.0', '0', '2017-02-21 17:15:51');
INSERT INTO `tp_operating` VALUES ('275', '1', 'admin/user/uedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 17:17:35');
INSERT INTO `tp_operating` VALUES ('276', '1', 'admin/user/uedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 17:18:59');
INSERT INTO `tp_operating` VALUES ('277', '1', 'admin/user/uedit_do', '修改密码成功', '0.0.0.0', '0', '2017-02-21 17:19:20');
INSERT INTO `tp_operating` VALUES ('278', '1', 'admin/user/uedit_do', '更新失败：', '0.0.0.0', '1', '2017-02-21 17:21:07');
INSERT INTO `tp_operating` VALUES ('279', '1', 'admin/user/uedit_do', '修改密码成功', '0.0.0.0', '0', '2017-02-21 17:21:16');
INSERT INTO `tp_operating` VALUES ('280', '1', 'admin/user/uedit_do', '修改密码成功', '0.0.0.0', '0', '2017-02-21 17:21:37');
INSERT INTO `tp_operating` VALUES ('281', '1', 'admin/user/uedit_do', '修改密码成功', '0.0.0.0', '0', '2017-02-21 17:21:46');
INSERT INTO `tp_operating` VALUES ('282', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-02-21 17:22:32');
INSERT INTO `tp_operating` VALUES ('283', '1', 'admin/user/useredit_do', '更新失败：小张', '0.0.0.0', '1', '2017-02-21 17:23:23');
INSERT INTO `tp_operating` VALUES ('284', '1', 'admin/user/useredit_do', '更改用户资料：小张', '0.0.0.0', '0', '2017-02-21 17:23:43');
INSERT INTO `tp_operating` VALUES ('285', '1', 'admin/system/ipadd_do', '新增IP限制登录成功', '0.0.0.0', '0', '2017-02-21 17:41:03');
INSERT INTO `tp_operating` VALUES ('286', '1', 'admin/user/uedit_do', '修改密码成功', '0.0.0.0', '0', '2017-02-21 21:39:41');
INSERT INTO `tp_operating` VALUES ('287', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:41:51');
INSERT INTO `tp_operating` VALUES ('288', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:41:55');
INSERT INTO `tp_operating` VALUES ('289', '1', 'admin/competence/cdel', '删除失败', '0.0.0.0', '1', '2017-02-21 21:41:57');
INSERT INTO `tp_operating` VALUES ('290', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:01');
INSERT INTO `tp_operating` VALUES ('291', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:05');
INSERT INTO `tp_operating` VALUES ('292', '1', 'admin/competence/cdel', '删除失败', '0.0.0.0', '1', '2017-02-21 21:42:07');
INSERT INTO `tp_operating` VALUES ('293', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:10');
INSERT INTO `tp_operating` VALUES ('294', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:14');
INSERT INTO `tp_operating` VALUES ('295', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:17');
INSERT INTO `tp_operating` VALUES ('296', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:21');
INSERT INTO `tp_operating` VALUES ('297', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:25');
INSERT INTO `tp_operating` VALUES ('298', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:28');
INSERT INTO `tp_operating` VALUES ('299', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:32');
INSERT INTO `tp_operating` VALUES ('300', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:35');
INSERT INTO `tp_operating` VALUES ('301', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:39');
INSERT INTO `tp_operating` VALUES ('302', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:43');
INSERT INTO `tp_operating` VALUES ('303', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:47');
INSERT INTO `tp_operating` VALUES ('304', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:42:56');
INSERT INTO `tp_operating` VALUES ('305', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:00');
INSERT INTO `tp_operating` VALUES ('306', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:04');
INSERT INTO `tp_operating` VALUES ('307', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:17');
INSERT INTO `tp_operating` VALUES ('308', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:24');
INSERT INTO `tp_operating` VALUES ('309', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:28');
INSERT INTO `tp_operating` VALUES ('310', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:31');
INSERT INTO `tp_operating` VALUES ('311', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:35');
INSERT INTO `tp_operating` VALUES ('312', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:39');
INSERT INTO `tp_operating` VALUES ('313', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:43');
INSERT INTO `tp_operating` VALUES ('314', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:47');
INSERT INTO `tp_operating` VALUES ('315', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:51');
INSERT INTO `tp_operating` VALUES ('316', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:55');
INSERT INTO `tp_operating` VALUES ('317', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:43:59');
INSERT INTO `tp_operating` VALUES ('318', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:44:33');
INSERT INTO `tp_operating` VALUES ('319', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:44:38');
INSERT INTO `tp_operating` VALUES ('320', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:44:42');
INSERT INTO `tp_operating` VALUES ('321', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:44:47');
INSERT INTO `tp_operating` VALUES ('322', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:44:51');
INSERT INTO `tp_operating` VALUES ('323', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:44:55');
INSERT INTO `tp_operating` VALUES ('324', '1', 'admin/competence/cdel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:45:00');
INSERT INTO `tp_operating` VALUES ('325', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 21:46:06');
INSERT INTO `tp_operating` VALUES ('326', '1', 'admin/dmenu/del', '删除成功', '0.0.0.0', '0', '2017-02-21 21:51:24');
INSERT INTO `tp_operating` VALUES ('327', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 21:51:30');
INSERT INTO `tp_operating` VALUES ('328', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 21:51:41');
INSERT INTO `tp_operating` VALUES ('329', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 21:51:47');
INSERT INTO `tp_operating` VALUES ('330', '1', 'admin/news/classedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 21:52:24');
INSERT INTO `tp_operating` VALUES ('331', '1', 'admin/news/classedit_do', '更新成功', '0.0.0.0', '0', '2017-02-21 21:52:32');
INSERT INTO `tp_operating` VALUES ('332', '1', 'admin/news/classadd_do', '新增成功', '0.0.0.0', '0', '2017-02-21 21:52:40');
INSERT INTO `tp_operating` VALUES ('333', '1', 'admin/news/newsindel', '删除成功', '0.0.0.0', '0', '2017-02-21 21:54:48');
INSERT INTO `tp_operating` VALUES ('334', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-02-21 21:55:56');
INSERT INTO `tp_operating` VALUES ('335', '1', 'admin/user/useradd_do', '新增用户：kobe', '61.178.84.19', '0', '2017-02-22 14:26:59');
INSERT INTO `tp_operating` VALUES ('341', '1', 'admin/user/useradd_do', '新增用户：dede', '61.178.84.19', '0', '2017-02-23 08:27:51');
INSERT INTO `tp_operating` VALUES ('340', '1', 'admin/news/newsdel', '删除成功', '61.178.84.19', '0', '2017-02-22 14:57:59');
INSERT INTO `tp_operating` VALUES ('339', '1', 'admin/news/add_do', '新增成功', '61.178.84.19', '0', '2017-02-22 14:57:54');
INSERT INTO `tp_operating` VALUES ('342', '1', 'admin/user/useredit_do', '更改用户资料：admin', '61.178.84.19', '0', '2017-02-23 08:28:10');
INSERT INTO `tp_operating` VALUES ('343', '1', 'admin/user/useredit_do', '更改用户资料：dede', '61.178.84.19', '0', '2017-02-23 08:29:15');
INSERT INTO `tp_operating` VALUES ('344', '1', 'admin/user/useradd_do', '新增用户：www', '61.178.84.19', '0', '2017-02-23 08:34:41');
INSERT INTO `tp_operating` VALUES ('345', '1', 'admin/user/useradd_do', '新增用户：AAA', '61.178.84.19', '0', '2017-02-23 08:45:14');
INSERT INTO `tp_operating` VALUES ('346', '1', 'admin/role/roleadd_do', '新增成功', '61.178.84.19', '0', '2017-02-23 08:45:59');
INSERT INTO `tp_operating` VALUES ('347', '1', 'admin/competence/cadd_do', '新增成功', '61.178.84.19', '0', '2017-02-23 08:46:33');
INSERT INTO `tp_operating` VALUES ('348', '1', 'admin/competence/cdel', '删除成功', '61.178.84.19', '0', '2017-02-23 08:46:39');
INSERT INTO `tp_operating` VALUES ('349', '1', 'admin/system/module_add_do', '新增模块成功', '61.178.84.19', '0', '2017-02-23 08:47:24');
INSERT INTO `tp_operating` VALUES ('350', '1', 'admin/system/moduledel', '删除模块成功', '61.178.84.19', '0', '2017-02-23 08:47:41');
INSERT INTO `tp_operating` VALUES ('351', '1', 'admin/system/ipadd_do', '新增IP限制登录成功', '61.178.84.19', '0', '2017-02-23 08:48:55');
INSERT INTO `tp_operating` VALUES ('352', '1', 'admin/loginlog/indel', '登录日志删除成功', '61.178.84.19', '0', '2017-02-23 08:51:46');
INSERT INTO `tp_operating` VALUES ('353', '1', 'admin/loginlog/del', '登录日志删除成功', '61.178.84.19', '0', '2017-02-24 17:00:41');
INSERT INTO `tp_operating` VALUES ('354', '1', 'admin/user/useredit_do', '更改用户资料：admin', '125.38.170.88', '0', '2017-02-25 19:12:43');
INSERT INTO `tp_operating` VALUES ('356', '1', 'admin/role/roleedit_do', '更新成功', '180.173.245.140', '0', '2017-03-07 15:47:13');
INSERT INTO `tp_operating` VALUES ('357', '1', 'admin/role/roleedit', '参数错误', '180.173.245.140', '1', '2017-03-07 15:47:15');
INSERT INTO `tp_operating` VALUES ('358', '1', 'admin/user/useradd_do', '新增用户：admin3', '124.235.153.58', '0', '2017-03-07 16:14:19');
INSERT INTO `tp_operating` VALUES ('359', '1', 'admin/news/classadd_do', '新增成功', '180.173.245.140', '0', '2017-03-07 17:38:08');
INSERT INTO `tp_operating` VALUES ('360', '1', 'admin/user/useradd_do', '新增用户：334455', '117.29.202.69', '0', '2017-03-07 22:07:13');
INSERT INTO `tp_operating` VALUES ('361', '1', 'admin/news/add_do', '新增成功', '61.178.84.19', '0', '2017-03-08 17:12:33');
INSERT INTO `tp_operating` VALUES ('362', '1', 'admin/news/add_do', '新增成功', '61.178.84.19', '0', '2017-03-08 17:12:41');
INSERT INTO `tp_operating` VALUES ('363', '1', 'admin/news/add_do', '新增成功', '61.178.84.19', '0', '2017-03-08 17:12:49');
INSERT INTO `tp_operating` VALUES ('364', '1', 'admin/news/classdel', '删除成功', '61.178.84.19', '0', '2017-03-08 17:31:16');
INSERT INTO `tp_operating` VALUES ('365', '1', 'admin/user/userdel', '不能删除系统默认用户', '223.21.130.55', '1', '2017-03-11 23:09:56');
INSERT INTO `tp_operating` VALUES ('366', '1', 'admin/user/userdel', '删除用户ID为：5的数据', '223.21.130.55', '0', '2017-03-11 23:10:01');
INSERT INTO `tp_operating` VALUES ('367', '1', 'admin/news/classdel', '删除成功', '223.21.130.55', '0', '2017-03-11 23:11:31');
INSERT INTO `tp_operating` VALUES ('368', '1', 'admin/news/classdel', '删除成功', '223.21.130.55', '0', '2017-03-11 23:11:37');
INSERT INTO `tp_operating` VALUES ('369', '1', 'admin/news/newsdel', '删除成功', '223.21.130.55', '0', '2017-03-11 23:11:53');
INSERT INTO `tp_operating` VALUES ('370', '1', 'admin/system/module_add_do', '新增模块成功', '49.210.144.20', '0', '2017-03-12 11:24:51');
INSERT INTO `tp_operating` VALUES ('371', '1', 'admin/user/userdel', '不能删除系统默认用户', '116.20.61.1', '1', '2017-03-12 22:59:28');
INSERT INTO `tp_operating` VALUES ('372', '1', 'admin/system/moduledel', '删除模块成功', '27.227.234.173', '0', '2017-03-13 21:38:50');
INSERT INTO `tp_operating` VALUES ('373', '1', 'admin/role/roleadd_do', '新增成功', '60.162.115.158', '0', '2017-03-14 13:19:56');
INSERT INTO `tp_operating` VALUES ('374', '1', 'admin/role/roleadd_do', '新增成功', '60.162.115.158', '0', '2017-03-14 13:20:36');
INSERT INTO `tp_operating` VALUES ('375', '1', 'admin/news/newsdel', '删除成功', '112.28.142.39', '0', '2017-03-14 19:23:26');
INSERT INTO `tp_operating` VALUES ('376', '1', 'admin/news/newsdel', '删除成功', '112.28.142.39', '0', '2017-03-14 19:23:31');
INSERT INTO `tp_operating` VALUES ('377', '1', 'admin/dmenu/del', '删除成功', '112.28.142.39', '0', '2017-03-14 19:33:27');
INSERT INTO `tp_operating` VALUES ('378', '1', 'admin/news/edit_do', '更新成功', '61.178.84.19', '0', '2017-03-15 10:28:55');
INSERT INTO `tp_operating` VALUES ('379', '1', 'admin/news/edit_do', '更新成功', '61.178.84.19', '0', '2017-03-15 10:29:00');
INSERT INTO `tp_operating` VALUES ('380', '1', 'admin/user/useradd_do', '新增用户：hailinhd', '110.152.25.101', '0', '2017-03-15 12:46:20');
INSERT INTO `tp_operating` VALUES ('381', '1', 'admin/user/useredit_do', '更改用户资料：hailinhd', '110.152.25.101', '0', '2017-03-15 12:47:50');
INSERT INTO `tp_operating` VALUES ('382', '1', 'admin/user/useredit_do', '更改用户资料：hailinhd', '110.152.25.101', '0', '2017-03-15 12:49:13');
INSERT INTO `tp_operating` VALUES ('383', '1', 'admin/user/userdel', '删除用户ID为：14的数据', '39.190.219.236', '0', '2017-03-16 22:02:00');
INSERT INTO `tp_operating` VALUES ('384', '1', 'admin/system/module_add_do', '新增模块成功', '222.220.205.48', '0', '2017-03-18 09:53:01');
INSERT INTO `tp_operating` VALUES ('385', '1', 'admin/system/moduledel', '删除模块成功', '61.178.84.19', '0', '2017-04-11 14:31:33');
INSERT INTO `tp_operating` VALUES ('386', '1', 'admin/news/edit_do', '更新成功', '0.0.0.0', '0', '2017-04-25 09:54:14');
INSERT INTO `tp_operating` VALUES ('387', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-05-12 14:51:51');
INSERT INTO `tp_operating` VALUES ('388', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-05-22 14:36:43');
INSERT INTO `tp_operating` VALUES ('389', '1', 'admin/news/edit_do', '更新失败：', '0.0.0.0', '1', '2017-05-22 14:37:22');
INSERT INTO `tp_operating` VALUES ('390', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-05-22 14:37:47');
INSERT INTO `tp_operating` VALUES ('391', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-05-22 14:41:26');
INSERT INTO `tp_operating` VALUES ('392', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-05-22 14:49:30');
INSERT INTO `tp_operating` VALUES ('393', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-05-22 15:00:17');
INSERT INTO `tp_operating` VALUES ('394', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-05-22 15:18:44');
INSERT INTO `tp_operating` VALUES ('395', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-05-22 15:21:49');
INSERT INTO `tp_operating` VALUES ('396', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-05-22 15:28:00');
INSERT INTO `tp_operating` VALUES ('397', '1', 'admin/dmenu/del', '删除成功', '0.0.0.0', '0', '2017-05-22 15:28:32');
INSERT INTO `tp_operating` VALUES ('398', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-06-07 11:59:38');
INSERT INTO `tp_operating` VALUES ('399', '1', 'admin/user/useradd_do', '新增用户：aa', '0.0.0.0', '0', '2017-06-07 12:08:45');
INSERT INTO `tp_operating` VALUES ('400', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-07-04 14:03:21');
INSERT INTO `tp_operating` VALUES ('401', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 15:35:13');
INSERT INTO `tp_operating` VALUES ('402', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 15:35:50');
INSERT INTO `tp_operating` VALUES ('403', '1', 'admin/link/edit', '数据不存在', '0.0.0.0', '1', '2017-07-08 16:17:23');
INSERT INTO `tp_operating` VALUES ('404', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 17:09:26');
INSERT INTO `tp_operating` VALUES ('405', '1', 'admin/link/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-08 17:10:33');
INSERT INTO `tp_operating` VALUES ('406', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 17:14:39');
INSERT INTO `tp_operating` VALUES ('407', '1', 'admin/link/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-08 17:15:26');
INSERT INTO `tp_operating` VALUES ('408', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 17:38:12');
INSERT INTO `tp_operating` VALUES ('409', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 17:38:17');
INSERT INTO `tp_operating` VALUES ('410', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 17:38:20');
INSERT INTO `tp_operating` VALUES ('411', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-08 17:38:22');
INSERT INTO `tp_operating` VALUES ('412', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:15:55');
INSERT INTO `tp_operating` VALUES ('413', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:16:03');
INSERT INTO `tp_operating` VALUES ('414', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:16:07');
INSERT INTO `tp_operating` VALUES ('415', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:21:40');
INSERT INTO `tp_operating` VALUES ('416', '1', 'admin/link/del', '参数错误', '0.0.0.0', '1', '2017-07-11 09:24:45');
INSERT INTO `tp_operating` VALUES ('417', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:59:34');
INSERT INTO `tp_operating` VALUES ('418', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:59:35');
INSERT INTO `tp_operating` VALUES ('419', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:59:36');
INSERT INTO `tp_operating` VALUES ('420', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 09:59:36');
INSERT INTO `tp_operating` VALUES ('421', '1', 'admin/link/del', '参数错误', '0.0.0.0', '1', '2017-07-11 09:59:42');
INSERT INTO `tp_operating` VALUES ('422', '1', 'admin/link/del', '参数错误', '0.0.0.0', '1', '2017-07-11 09:59:47');
INSERT INTO `tp_operating` VALUES ('423', '1', 'admin/link/del', '参数错误', '0.0.0.0', '1', '2017-07-11 10:00:16');
INSERT INTO `tp_operating` VALUES ('424', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-11 10:00:40');
INSERT INTO `tp_operating` VALUES ('425', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-11 10:00:46');
INSERT INTO `tp_operating` VALUES ('426', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-11 10:01:02');
INSERT INTO `tp_operating` VALUES ('427', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-11 10:01:36');
INSERT INTO `tp_operating` VALUES ('428', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-11 10:01:41');
INSERT INTO `tp_operating` VALUES ('429', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 10:01:48');
INSERT INTO `tp_operating` VALUES ('430', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 10:01:54');
INSERT INTO `tp_operating` VALUES ('431', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 10:02:00');
INSERT INTO `tp_operating` VALUES ('432', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 10:02:06');
INSERT INTO `tp_operating` VALUES ('433', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-11 10:02:11');
INSERT INTO `tp_operating` VALUES ('434', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-11 10:06:32');
INSERT INTO `tp_operating` VALUES ('435', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 10:06:46');
INSERT INTO `tp_operating` VALUES ('436', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:20');
INSERT INTO `tp_operating` VALUES ('437', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:23');
INSERT INTO `tp_operating` VALUES ('438', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:25');
INSERT INTO `tp_operating` VALUES ('439', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:29');
INSERT INTO `tp_operating` VALUES ('440', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:31');
INSERT INTO `tp_operating` VALUES ('441', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:34');
INSERT INTO `tp_operating` VALUES ('442', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:37');
INSERT INTO `tp_operating` VALUES ('443', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:40');
INSERT INTO `tp_operating` VALUES ('444', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:42');
INSERT INTO `tp_operating` VALUES ('445', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:45');
INSERT INTO `tp_operating` VALUES ('446', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:48');
INSERT INTO `tp_operating` VALUES ('447', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:06:50');
INSERT INTO `tp_operating` VALUES ('448', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:09:34');
INSERT INTO `tp_operating` VALUES ('449', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-11 14:09:37');
INSERT INTO `tp_operating` VALUES ('450', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-12 11:09:46');
INSERT INTO `tp_operating` VALUES ('451', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-12 11:09:58');
INSERT INTO `tp_operating` VALUES ('452', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-12 11:17:03');
INSERT INTO `tp_operating` VALUES ('453', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-12 11:44:10');
INSERT INTO `tp_operating` VALUES ('454', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-12 11:44:13');
INSERT INTO `tp_operating` VALUES ('455', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-12 11:44:17');
INSERT INTO `tp_operating` VALUES ('456', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-12 11:44:49');
INSERT INTO `tp_operating` VALUES ('457', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-12 11:45:14');
INSERT INTO `tp_operating` VALUES ('458', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-07-12 11:45:24');
INSERT INTO `tp_operating` VALUES ('459', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-12 11:45:38');
INSERT INTO `tp_operating` VALUES ('460', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-12 11:45:50');
INSERT INTO `tp_operating` VALUES ('461', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-12 11:46:03');
INSERT INTO `tp_operating` VALUES ('462', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-07-12 11:46:10');
INSERT INTO `tp_operating` VALUES ('463', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-07-12 11:48:52');
INSERT INTO `tp_operating` VALUES ('464', '1', 'admin/user/useradd_do', '新增用户：why', '0.0.0.0', '0', '2017-07-12 11:49:12');
INSERT INTO `tp_operating` VALUES ('465', '1', 'admin/user/useredit_do', '更改用户资料：why', '0.0.0.0', '0', '2017-07-12 11:50:50');
INSERT INTO `tp_operating` VALUES ('466', '1', 'admin/role/roleedit_do', '更新失败：', '0.0.0.0', '1', '2017-07-12 11:51:12');
INSERT INTO `tp_operating` VALUES ('467', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-07-12 11:51:18');
INSERT INTO `tp_operating` VALUES ('468', '17', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 11:53:40');
INSERT INTO `tp_operating` VALUES ('469', '17', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:53:43');
INSERT INTO `tp_operating` VALUES ('470', '17', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:53:47');
INSERT INTO `tp_operating` VALUES ('471', '17', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:54:18');
INSERT INTO `tp_operating` VALUES ('472', '17', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:56:23');
INSERT INTO `tp_operating` VALUES ('473', '17', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:57:12');
INSERT INTO `tp_operating` VALUES ('474', '17', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:57:48');
INSERT INTO `tp_operating` VALUES ('475', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-07-12 11:58:23');
INSERT INTO `tp_operating` VALUES ('476', '1', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:58:40');
INSERT INTO `tp_operating` VALUES ('477', '1', 'admin/link/edit', '参数错误', '0.0.0.0', '1', '2017-07-12 11:58:45');
INSERT INTO `tp_operating` VALUES ('478', '17', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-12 12:04:41');
INSERT INTO `tp_operating` VALUES ('479', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-12 17:08:07');
INSERT INTO `tp_operating` VALUES ('480', '1', 'admin/link/del', '删除成功', '0.0.0.0', '0', '2017-07-12 17:08:16');
INSERT INTO `tp_operating` VALUES ('481', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 17:16:56');
INSERT INTO `tp_operating` VALUES ('482', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 17:23:10');
INSERT INTO `tp_operating` VALUES ('483', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 17:24:58');
INSERT INTO `tp_operating` VALUES ('484', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 17:26:18');
INSERT INTO `tp_operating` VALUES ('485', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 17:45:32');
INSERT INTO `tp_operating` VALUES ('486', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-12 17:59:27');
INSERT INTO `tp_operating` VALUES ('487', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-13 08:54:55');
INSERT INTO `tp_operating` VALUES ('488', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-13 08:56:04');
INSERT INTO `tp_operating` VALUES ('489', '1', 'admin/link/deleteimage', '更新成功', '0.0.0.0', '0', '2017-07-13 09:39:22');
INSERT INTO `tp_operating` VALUES ('490', '1', 'admin/link/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-13 09:40:58');
INSERT INTO `tp_operating` VALUES ('491', '1', 'admin/link/deleteimage', '图片删除成功', '0.0.0.0', '0', '2017-07-13 09:44:49');
INSERT INTO `tp_operating` VALUES ('492', '1', 'admin/link/deleteimage', '图片删除失败：', '0.0.0.0', '1', '2017-07-13 09:45:42');
INSERT INTO `tp_operating` VALUES ('493', '1', 'admin/link/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-13 09:45:49');
INSERT INTO `tp_operating` VALUES ('494', '1', 'admin/link/deleteimage', '图片删除成功', '0.0.0.0', '0', '2017-07-13 09:50:07');
INSERT INTO `tp_operating` VALUES ('495', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-13 10:16:02');
INSERT INTO `tp_operating` VALUES ('496', '1', 'admin/link/indel', '删除成功', '0.0.0.0', '0', '2017-07-13 10:18:38');
INSERT INTO `tp_operating` VALUES ('497', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-13 10:18:51');
INSERT INTO `tp_operating` VALUES ('498', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-13 10:37:52');
INSERT INTO `tp_operating` VALUES ('499', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-13 10:45:30');
INSERT INTO `tp_operating` VALUES ('500', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-13 10:46:08');
INSERT INTO `tp_operating` VALUES ('501', '1', 'admin/link/editfield', '更新成功', '0.0.0.0', '0', '2017-07-13 10:46:15');
INSERT INTO `tp_operating` VALUES ('502', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-07-22 11:12:50');
INSERT INTO `tp_operating` VALUES ('503', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 10:55:10');
INSERT INTO `tp_operating` VALUES ('504', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 10:55:18');
INSERT INTO `tp_operating` VALUES ('505', '1', 'admin/advertisement/del', '删除成功', '0.0.0.0', '0', '2017-07-24 10:56:00');
INSERT INTO `tp_operating` VALUES ('506', '1', 'admin/advertisement/indel', '删除成功', '0.0.0.0', '0', '2017-07-24 10:56:05');
INSERT INTO `tp_operating` VALUES ('507', '1', 'admin/advertisement/add_do', '新增成功', '0.0.0.0', '0', '2017-07-24 12:07:41');
INSERT INTO `tp_operating` VALUES ('508', '1', 'admin/advertisement/add_do', '新增成功', '0.0.0.0', '0', '2017-07-24 12:09:48');
INSERT INTO `tp_operating` VALUES ('509', '1', 'admin/advertisement/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 14:46:18');
INSERT INTO `tp_operating` VALUES ('510', '1', 'admin/advertisement/deleteimage', '图片删除成功', '0.0.0.0', '0', '2017-07-24 14:47:23');
INSERT INTO `tp_operating` VALUES ('511', '1', 'admin/advertisement/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 14:47:30');
INSERT INTO `tp_operating` VALUES ('512', '1', 'admin/advertisement/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 14:47:59');
INSERT INTO `tp_operating` VALUES ('513', '1', 'admin/advertisement/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 14:48:09');
INSERT INTO `tp_operating` VALUES ('514', '1', 'admin/advertisement/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 14:50:23');
INSERT INTO `tp_operating` VALUES ('515', '1', 'admin/advertisement/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 14:51:44');
INSERT INTO `tp_operating` VALUES ('516', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:32:43');
INSERT INTO `tp_operating` VALUES ('517', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:37:02');
INSERT INTO `tp_operating` VALUES ('518', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:37:14');
INSERT INTO `tp_operating` VALUES ('519', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:43:05');
INSERT INTO `tp_operating` VALUES ('520', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:45:57');
INSERT INTO `tp_operating` VALUES ('521', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:46:04');
INSERT INTO `tp_operating` VALUES ('522', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:46:15');
INSERT INTO `tp_operating` VALUES ('523', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:46:24');
INSERT INTO `tp_operating` VALUES ('524', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 15:51:46');
INSERT INTO `tp_operating` VALUES ('525', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:52:26');
INSERT INTO `tp_operating` VALUES ('526', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:52:38');
INSERT INTO `tp_operating` VALUES ('527', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:54:21');
INSERT INTO `tp_operating` VALUES ('528', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:54:27');
INSERT INTO `tp_operating` VALUES ('529', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:54:33');
INSERT INTO `tp_operating` VALUES ('530', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:54:39');
INSERT INTO `tp_operating` VALUES ('531', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 16:54:59');
INSERT INTO `tp_operating` VALUES ('532', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:01:15');
INSERT INTO `tp_operating` VALUES ('533', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:01:33');
INSERT INTO `tp_operating` VALUES ('534', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:03:06');
INSERT INTO `tp_operating` VALUES ('535', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:03:20');
INSERT INTO `tp_operating` VALUES ('536', '1', 'admin/advertisement/editfield', '更新失败：', '0.0.0.0', '1', '2017-07-24 17:12:21');
INSERT INTO `tp_operating` VALUES ('537', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:13:16');
INSERT INTO `tp_operating` VALUES ('538', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:15:23');
INSERT INTO `tp_operating` VALUES ('539', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:21:05');
INSERT INTO `tp_operating` VALUES ('540', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:21:59');
INSERT INTO `tp_operating` VALUES ('541', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:22:15');
INSERT INTO `tp_operating` VALUES ('542', '1', 'admin/advertisement/editfield', '更新成功', '0.0.0.0', '0', '2017-07-24 17:22:22');
INSERT INTO `tp_operating` VALUES ('543', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:31:41');
INSERT INTO `tp_operating` VALUES ('544', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:31:54');
INSERT INTO `tp_operating` VALUES ('545', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:32:07');
INSERT INTO `tp_operating` VALUES ('546', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:32:18');
INSERT INTO `tp_operating` VALUES ('547', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:32:27');
INSERT INTO `tp_operating` VALUES ('548', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 17:32:38');
INSERT INTO `tp_operating` VALUES ('549', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 17:32:44');
INSERT INTO `tp_operating` VALUES ('550', '1', 'admin/link/add_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:46:51');
INSERT INTO `tp_operating` VALUES ('551', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-07-24 17:47:58');
INSERT INTO `tp_operating` VALUES ('552', '1', 'admin/advertisement/add_do', '新增成功', '0.0.0.0', '0', '2017-07-24 17:48:31');
INSERT INTO `tp_operating` VALUES ('553', '1', 'admin/advertisement/editfield', '更新失败：', '0.0.0.0', '1', '2017-07-25 09:06:42');
INSERT INTO `tp_operating` VALUES ('554', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-07-29 10:52:30');
INSERT INTO `tp_operating` VALUES ('555', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 10:52:37');
INSERT INTO `tp_operating` VALUES ('556', '1', 'admin/page/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 11:32:53');
INSERT INTO `tp_operating` VALUES ('557', '1', 'admin/page/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-29 11:45:08');
INSERT INTO `tp_operating` VALUES ('558', '1', 'admin/page/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-29 11:45:18');
INSERT INTO `tp_operating` VALUES ('559', '1', 'admin/page/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 11:52:39');
INSERT INTO `tp_operating` VALUES ('560', '1', 'admin/page/indel', '删除成功', '0.0.0.0', '0', '2017-07-29 11:52:52');
INSERT INTO `tp_operating` VALUES ('561', '1', 'admin/page/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 11:53:17');
INSERT INTO `tp_operating` VALUES ('562', '1', 'admin/page/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 11:53:49');
INSERT INTO `tp_operating` VALUES ('563', '1', 'admin/page/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 11:55:20');
INSERT INTO `tp_operating` VALUES ('564', '1', 'admin/page/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 11:56:01');
INSERT INTO `tp_operating` VALUES ('565', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-07-29 14:41:21');
INSERT INTO `tp_operating` VALUES ('566', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-07-29 14:41:56');
INSERT INTO `tp_operating` VALUES ('567', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-07-29 14:43:55');
INSERT INTO `tp_operating` VALUES ('568', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 14:44:01');
INSERT INTO `tp_operating` VALUES ('569', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 14:44:43');
INSERT INTO `tp_operating` VALUES ('570', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 14:45:19');
INSERT INTO `tp_operating` VALUES ('571', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 14:55:38');
INSERT INTO `tp_operating` VALUES ('572', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 14:56:04');
INSERT INTO `tp_operating` VALUES ('573', '1', 'admin/admin/clearcache', '清空站点缓存', '0.0.0.0', '0', '2017-07-29 14:56:34');
INSERT INTO `tp_operating` VALUES ('574', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:24:33');
INSERT INTO `tp_operating` VALUES ('575', '1', 'admin/goods/edit', '参数错误', '0.0.0.0', '1', '2017-07-29 15:25:46');
INSERT INTO `tp_operating` VALUES ('576', '1', 'admin/goods/edit', '参数错误', '0.0.0.0', '1', '2017-07-29 15:27:14');
INSERT INTO `tp_operating` VALUES ('577', '1', 'admin/goods/edit', '参数错误', '0.0.0.0', '1', '2017-07-29 15:27:17');
INSERT INTO `tp_operating` VALUES ('578', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:28:58');
INSERT INTO `tp_operating` VALUES ('579', '1', 'admin/goods/edit', '参数错误', '0.0.0.0', '1', '2017-07-29 15:29:02');
INSERT INTO `tp_operating` VALUES ('580', '1', 'admin/goods/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-29 15:33:07');
INSERT INTO `tp_operating` VALUES ('581', '1', 'admin/goods/del', '删除成功', '0.0.0.0', '0', '2017-07-29 15:34:24');
INSERT INTO `tp_operating` VALUES ('582', '1', 'admin/goods/del', '删除失败', '0.0.0.0', '1', '2017-07-29 15:34:25');
INSERT INTO `tp_operating` VALUES ('583', '1', 'admin/goods/del', '删除成功', '0.0.0.0', '0', '2017-07-29 15:34:50');
INSERT INTO `tp_operating` VALUES ('584', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:35:58');
INSERT INTO `tp_operating` VALUES ('585', '1', 'admin/goods/del', '删除成功', '0.0.0.0', '0', '2017-07-29 15:36:09');
INSERT INTO `tp_operating` VALUES ('586', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:43:59');
INSERT INTO `tp_operating` VALUES ('587', '1', 'admin/goods/del', '删除成功', '0.0.0.0', '0', '2017-07-29 15:44:04');
INSERT INTO `tp_operating` VALUES ('588', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:44:53');
INSERT INTO `tp_operating` VALUES ('589', '1', 'admin/goods/del', '删除成功', '0.0.0.0', '0', '2017-07-29 15:44:57');
INSERT INTO `tp_operating` VALUES ('590', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:45:37');
INSERT INTO `tp_operating` VALUES ('591', '1', 'admin/goods/del', '删除成功', '0.0.0.0', '0', '2017-07-29 15:45:43');
INSERT INTO `tp_operating` VALUES ('592', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:45:55');
INSERT INTO `tp_operating` VALUES ('593', '1', 'admin/goods/indel', '删除成功', '0.0.0.0', '0', '2017-07-29 15:45:59');
INSERT INTO `tp_operating` VALUES ('594', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:46:44');
INSERT INTO `tp_operating` VALUES ('595', '1', 'admin/goods/indel', '删除成功', '0.0.0.0', '0', '2017-07-29 15:46:46');
INSERT INTO `tp_operating` VALUES ('596', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:49:47');
INSERT INTO `tp_operating` VALUES ('597', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 15:50:24');
INSERT INTO `tp_operating` VALUES ('598', '1', 'admin/goods/indel', '删除成功', '0.0.0.0', '0', '2017-07-29 15:54:13');
INSERT INTO `tp_operating` VALUES ('599', '1', 'admin/goods/add_do', '新增成功', '0.0.0.0', '0', '2017-07-29 16:08:02');
INSERT INTO `tp_operating` VALUES ('600', '1', 'admin/goods/editfield', '更新成功', '0.0.0.0', '0', '2017-07-29 16:10:07');
INSERT INTO `tp_operating` VALUES ('601', '1', 'admin/goods/edit_do', '更新成功', '0.0.0.0', '0', '2017-07-29 16:10:19');
INSERT INTO `tp_operating` VALUES ('602', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-07-31 10:15:00');
INSERT INTO `tp_operating` VALUES ('603', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-07-31 10:19:12');
INSERT INTO `tp_operating` VALUES ('604', '1', 'admin/system/ipadd_do', '新增IP限制登录成功', '0.0.0.0', '0', '2017-08-01 10:31:21');
INSERT INTO `tp_operating` VALUES ('605', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-14 16:14:43');
INSERT INTO `tp_operating` VALUES ('606', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-14 16:15:04');
INSERT INTO `tp_operating` VALUES ('607', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-14 16:15:13');
INSERT INTO `tp_operating` VALUES ('608', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-14 16:15:29');
INSERT INTO `tp_operating` VALUES ('609', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-14 16:15:37');
INSERT INTO `tp_operating` VALUES ('610', '1', 'admin/role/roleedit_do', '更新成功', '0.0.0.0', '0', '2017-08-14 16:28:12');
INSERT INTO `tp_operating` VALUES ('611', '1', 'admin/role/roleedit', '参数错误', '0.0.0.0', '1', '2017-08-14 16:28:14');
INSERT INTO `tp_operating` VALUES ('612', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-08-14 17:27:59');
INSERT INTO `tp_operating` VALUES ('613', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-14 17:35:08');
INSERT INTO `tp_operating` VALUES ('614', '1', 'admin/system/module_edit_do', '更新失败：', '0.0.0.0', '1', '2017-08-14 17:35:38');
INSERT INTO `tp_operating` VALUES ('615', '1', 'admin/system/module_edit_do', '更新失败：', '0.0.0.0', '1', '2017-08-14 17:35:41');
INSERT INTO `tp_operating` VALUES ('616', '1', 'admin/system/module_edit_do', '更新失败：', '0.0.0.0', '1', '2017-08-14 17:35:45');
INSERT INTO `tp_operating` VALUES ('617', '1', 'admin/system/module_edit_do', '更新失败：', '0.0.0.0', '1', '2017-08-14 17:36:01');
INSERT INTO `tp_operating` VALUES ('618', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-14 17:36:40');
INSERT INTO `tp_operating` VALUES ('619', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-14 17:36:45');
INSERT INTO `tp_operating` VALUES ('620', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:02:46');
INSERT INTO `tp_operating` VALUES ('621', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:02:58');
INSERT INTO `tp_operating` VALUES ('622', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:03:14');
INSERT INTO `tp_operating` VALUES ('623', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:03:22');
INSERT INTO `tp_operating` VALUES ('624', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:03:32');
INSERT INTO `tp_operating` VALUES ('625', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-08-15 09:05:32');
INSERT INTO `tp_operating` VALUES ('626', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:05:39');
INSERT INTO `tp_operating` VALUES ('627', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:05:59');
INSERT INTO `tp_operating` VALUES ('628', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:07:23');
INSERT INTO `tp_operating` VALUES ('629', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:07:30');
INSERT INTO `tp_operating` VALUES ('630', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:07:37');
INSERT INTO `tp_operating` VALUES ('631', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:07:47');
INSERT INTO `tp_operating` VALUES ('632', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:07:58');
INSERT INTO `tp_operating` VALUES ('633', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:08:23');
INSERT INTO `tp_operating` VALUES ('634', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:08:41');
INSERT INTO `tp_operating` VALUES ('635', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:08:49');
INSERT INTO `tp_operating` VALUES ('636', '1', 'admin/role/roleadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:10:06');
INSERT INTO `tp_operating` VALUES ('637', '1', 'admin/user/useradd_do', '新增用户：kefu', '0.0.0.0', '0', '2017-08-15 09:10:24');
INSERT INTO `tp_operating` VALUES ('638', '1', 'admin/user/useredit_do', '更改用户资料：kefu', '0.0.0.0', '0', '2017-08-15 09:10:48');
INSERT INTO `tp_operating` VALUES ('639', '1', 'admin/user/useradd_do', '新增用户：qqq', '0.0.0.0', '0', '2017-08-15 09:11:20');
INSERT INTO `tp_operating` VALUES ('640', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:24:49');
INSERT INTO `tp_operating` VALUES ('641', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:25:07');
INSERT INTO `tp_operating` VALUES ('642', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:25:16');
INSERT INTO `tp_operating` VALUES ('643', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:25:22');
INSERT INTO `tp_operating` VALUES ('644', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:25:28');
INSERT INTO `tp_operating` VALUES ('645', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:26:24');
INSERT INTO `tp_operating` VALUES ('646', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:26:33');
INSERT INTO `tp_operating` VALUES ('647', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:26:52');
INSERT INTO `tp_operating` VALUES ('648', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:27:07');
INSERT INTO `tp_operating` VALUES ('649', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:27:14');
INSERT INTO `tp_operating` VALUES ('650', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:27:21');
INSERT INTO `tp_operating` VALUES ('651', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:27:36');
INSERT INTO `tp_operating` VALUES ('652', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:27:54');
INSERT INTO `tp_operating` VALUES ('653', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:28:05');
INSERT INTO `tp_operating` VALUES ('654', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:28:13');
INSERT INTO `tp_operating` VALUES ('655', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:28:20');
INSERT INTO `tp_operating` VALUES ('656', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:29:06');
INSERT INTO `tp_operating` VALUES ('657', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:32:40');
INSERT INTO `tp_operating` VALUES ('658', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:32:54');
INSERT INTO `tp_operating` VALUES ('659', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:33:02');
INSERT INTO `tp_operating` VALUES ('660', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:33:08');
INSERT INTO `tp_operating` VALUES ('661', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:33:25');
INSERT INTO `tp_operating` VALUES ('662', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:34:10');
INSERT INTO `tp_operating` VALUES ('663', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:34:16');
INSERT INTO `tp_operating` VALUES ('664', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:34:23');
INSERT INTO `tp_operating` VALUES ('665', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:34:29');
INSERT INTO `tp_operating` VALUES ('666', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:34:33');
INSERT INTO `tp_operating` VALUES ('667', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:36:01');
INSERT INTO `tp_operating` VALUES ('668', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:36:23');
INSERT INTO `tp_operating` VALUES ('669', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:39:51');
INSERT INTO `tp_operating` VALUES ('670', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:40:46');
INSERT INTO `tp_operating` VALUES ('671', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:40:52');
INSERT INTO `tp_operating` VALUES ('672', '1', 'admin/competence/cedit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:40:58');
INSERT INTO `tp_operating` VALUES ('673', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:44:59');
INSERT INTO `tp_operating` VALUES ('674', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:45:08');
INSERT INTO `tp_operating` VALUES ('675', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 09:45:23');
INSERT INTO `tp_operating` VALUES ('676', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 09:55:47');
INSERT INTO `tp_operating` VALUES ('677', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 09:58:34');
INSERT INTO `tp_operating` VALUES ('678', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 10:05:09');
INSERT INTO `tp_operating` VALUES ('679', '1', 'admin/competence/cadd_do', '新增成功', '0.0.0.0', '0', '2017-08-15 10:05:19');
INSERT INTO `tp_operating` VALUES ('680', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:05:40');
INSERT INTO `tp_operating` VALUES ('681', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:06:07');
INSERT INTO `tp_operating` VALUES ('682', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:06:22');
INSERT INTO `tp_operating` VALUES ('683', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:06:34');
INSERT INTO `tp_operating` VALUES ('684', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:06:46');
INSERT INTO `tp_operating` VALUES ('685', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:07:08');
INSERT INTO `tp_operating` VALUES ('686', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:09:19');
INSERT INTO `tp_operating` VALUES ('687', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:09:32');
INSERT INTO `tp_operating` VALUES ('688', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-15 10:13:34');
INSERT INTO `tp_operating` VALUES ('689', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 10:58:13');
INSERT INTO `tp_operating` VALUES ('690', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 11:03:38');
INSERT INTO `tp_operating` VALUES ('691', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 11:56:33');
INSERT INTO `tp_operating` VALUES ('692', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 13:46:28');
INSERT INTO `tp_operating` VALUES ('693', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 13:47:12');
INSERT INTO `tp_operating` VALUES ('694', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 13:48:08');
INSERT INTO `tp_operating` VALUES ('695', '1', 'admin/user/useradd_do', '新增用户：rrr', '0.0.0.0', '0', '2017-08-15 14:08:09');
INSERT INTO `tp_operating` VALUES ('696', '1', 'admin/user/useredit_do', '更改用户资料：rrr', '0.0.0.0', '0', '2017-08-15 14:08:37');
INSERT INTO `tp_operating` VALUES ('697', '1', 'admin/user/useredit_do', '更改用户资料：rrr', '0.0.0.0', '0', '2017-08-15 14:08:58');
INSERT INTO `tp_operating` VALUES ('698', '1', 'admin/user/useredit_do', '更新失败：rrr', '0.0.0.0', '1', '2017-08-15 14:16:07');
INSERT INTO `tp_operating` VALUES ('699', '1', 'admin/user/useredit_do', '更改用户资料：rrr', '0.0.0.0', '0', '2017-08-15 14:16:21');
INSERT INTO `tp_operating` VALUES ('700', '1', 'admin/user/useredit_do', '更新失败：admin', '0.0.0.0', '1', '2017-08-15 16:49:26');
INSERT INTO `tp_operating` VALUES ('701', '1', 'admin/user/useredit_do', '更新失败：admin', '0.0.0.0', '1', '2017-08-15 16:49:40');
INSERT INTO `tp_operating` VALUES ('702', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 16:49:45');
INSERT INTO `tp_operating` VALUES ('703', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 16:49:58');
INSERT INTO `tp_operating` VALUES ('704', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-15 16:50:12');
INSERT INTO `tp_operating` VALUES ('705', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-16 14:33:57');
INSERT INTO `tp_operating` VALUES ('706', '1', 'admin/user/useredit_do', '更新失败：admin', '0.0.0.0', '1', '2017-08-16 14:34:08');
INSERT INTO `tp_operating` VALUES ('707', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-16 14:34:14');
INSERT INTO `tp_operating` VALUES ('708', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-16 14:34:23');
INSERT INTO `tp_operating` VALUES ('709', '1', 'admin/user/useredit_do', '更改用户资料：admin', '0.0.0.0', '0', '2017-08-16 14:34:30');
INSERT INTO `tp_operating` VALUES ('710', '1', 'admin/user/useradd_do', '新增用户：eeee', '0.0.0.0', '0', '2017-08-16 14:34:48');
INSERT INTO `tp_operating` VALUES ('711', '1', 'admin/user/in_user_del', '批量删除ID为：18,19,20,21的数据', '0.0.0.0', '0', '2017-08-16 14:42:12');
INSERT INTO `tp_operating` VALUES ('712', '1', 'admin/user/useradd_do', '新增用户：211212', '0.0.0.0', '0', '2017-08-16 14:42:24');
INSERT INTO `tp_operating` VALUES ('713', '1', 'admin/user/useredit_do', '更改用户资料：211212', '0.0.0.0', '0', '2017-08-16 14:43:09');
INSERT INTO `tp_operating` VALUES ('714', '1', 'admin/user/useredit_do', '更改用户资料：211212', '0.0.0.0', '0', '2017-08-16 14:43:21');
INSERT INTO `tp_operating` VALUES ('715', '1', 'admin/user/useredit_do', '更改用户资料：211212', '0.0.0.0', '0', '2017-08-16 14:43:30');
INSERT INTO `tp_operating` VALUES ('716', '1', 'admin/user/useradd_do', '新增用户：123456', '0.0.0.0', '0', '2017-08-16 14:43:47');
INSERT INTO `tp_operating` VALUES ('717', '1', 'admin/user/useradd_do', '新增用户：qqq', '0.0.0.0', '0', '2017-08-19 10:09:17');
INSERT INTO `tp_operating` VALUES ('718', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-08-30 16:43:56');
INSERT INTO `tp_operating` VALUES ('719', '1', 'admin/system/moduledel', '删除模块成功', '0.0.0.0', '0', '2017-08-30 16:44:10');
INSERT INTO `tp_operating` VALUES ('720', '1', 'admin/user/useredit_do', '更改用户资料：qqq', '0.0.0.0', '0', '2017-08-30 16:44:34');
INSERT INTO `tp_operating` VALUES ('721', '1', 'admin/user/useredit_do', '更新失败：qqq', '0.0.0.0', '1', '2017-08-30 16:54:25');
INSERT INTO `tp_operating` VALUES ('722', '1', 'admin/user/useredit_do', '更改用户资料：qqq', '0.0.0.0', '0', '2017-08-30 16:54:36');
INSERT INTO `tp_operating` VALUES ('723', '1', 'admin/system/module_edit_do', '更新成功', '0.0.0.0', '0', '2017-08-30 16:57:16');
INSERT INTO `tp_operating` VALUES ('724', '1', 'admin/system/module_add_do', '新增模块成功', '0.0.0.0', '0', '2017-09-02 16:13:30');
INSERT INTO `tp_operating` VALUES ('725', '1', 'admin/question/del', '参数错误', '0.0.0.0', '1', '2017-09-02 16:29:34');
INSERT INTO `tp_operating` VALUES ('726', '1', 'admin/question/del', '删除成功', '0.0.0.0', '0', '2017-09-02 16:31:01');
INSERT INTO `tp_operating` VALUES ('727', '1', 'admin/question/del', '删除成功', '0.0.0.0', '0', '2017-09-02 16:31:03');
INSERT INTO `tp_operating` VALUES ('728', '1', 'admin/question/indel', '删除成功', '0.0.0.0', '0', '2017-09-02 16:31:06');
INSERT INTO `tp_operating` VALUES ('729', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-09-02 17:00:00');
INSERT INTO `tp_operating` VALUES ('730', '1', 'admin/news/edit_do', '更新成功', '0.0.0.0', '0', '2017-09-02 17:01:48');
INSERT INTO `tp_operating` VALUES ('731', '1', 'admin/dmenu/dmenuadd_do', '新增成功', '0.0.0.0', '0', '2017-09-05 11:23:16');
INSERT INTO `tp_operating` VALUES ('732', '1', 'admin/news/classadd_do', '新增成功', '0.0.0.0', '0', '2017-09-08 15:39:44');
INSERT INTO `tp_operating` VALUES ('733', '1', 'admin/news/add_do', '新增成功', '0.0.0.0', '0', '2017-09-08 15:44:52');

-- ----------------------------
-- Table structure for `tp_page`
-- ----------------------------
DROP TABLE IF EXISTS `tp_page`;
CREATE TABLE `tp_page` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL COMMENT '标题',
  `title_second` varchar(100) NOT NULL DEFAULT '' COMMENT '副标题',
  `title_alias` char(40) NOT NULL COMMENT '标签',
  `html_path` varchar(100) NOT NULL DEFAULT '' COMMENT 'html路径',
  `html_file` varchar(100) NOT NULL DEFAULT '' COMMENT 'html文件',
  `intro` text COMMENT '简单描述',
  `content` mediumtext NOT NULL COMMENT '内容',
  `seo_title` varchar(255) NOT NULL DEFAULT '' COMMENT 'SEO标题',
  `seo_keywords` varchar(255) NOT NULL DEFAULT '' COMMENT 'SEO KEYWORDS',
  `seo_description` text COMMENT 'SEO DESCRIPTION',
  `template` varchar(30) NOT NULL DEFAULT '' COMMENT '模板',
  `attach_file` varchar(60) NOT NULL DEFAULT '' COMMENT '附件',
  `attach_thumb` varchar(60) NOT NULL DEFAULT '' COMMENT '附件小图',
  `sort_order` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT '排序',
  `view_count` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '查看次数',
  `status_is` enum('Y','N') NOT NULL DEFAULT 'Y' COMMENT '状态',
  `create_time` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '时间',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COMMENT='单页';

-- ----------------------------
-- Records of tp_page
-- ----------------------------
INSERT INTO `tp_page` VALUES ('7', '管理团队', '', 'team', '', '', '', '<p>团队是现代企业管理中战斗的核心，几乎没有一家企业不谈团队，好象团队就是企业做大做强的灵丹妙药，只要抓紧团队建设就能有锦锈前程了。团队是个好东西，但怎样的团队才算一个好团队，怎样才能运作好一个团队呢？却是许多企业管理者不甚了然的，于是在企业团队建设的过程中就出现了许多弊病，例如从理论著作中生搬硬套到团队运作里面，是很难产生好团队的。任何理念都不能执着，执着生僵化，就会蜕变为形式主义，后果很糟糕。在如今企业管理者热火朝天进行的团队建设中就存在这个问题，将团队作为企业文化建设的至上准则是不恰当的，是不符合多元化的现实状况的。</p><p>一个优秀的企业管理者，应该怎样管理员工?道理也很简单，那就是要给员工创造一个充分利用自己的个性将工作干得最好的条件。不一定什么都要团队化，太死板了。虽然现在的企业也都提倡创新，但如果管理者过分强调团队精神，则员工的创新精神必然受到压抑。压抑个性就是压抑创新，没有个性哪来的创新?说得极端一点，企业管理者要谨防团队建设法西斯化。团队是需要的，企业管理者在团队建设的同时要遵循一个原则，不能压抑员工的个性。在团队内部，企业管理者要给员工充分的自由，少说几句少数服从多数，要知道，聪明的人在世界上还就占少数。</p><p>企业管理者应该解放思想，要有多元化的思维。不同的企业，团队的性质也不一样。要量体裁衣建设符合企业内在要求的团队，要灵活变化，别搞一刀切。如果该企业是劳动密集型企业，那你可以建设一支高度纪律性组织性的团队。如果该企业是知识密集型企业，那就要以自由主义来管理员工了，建立一支人尽其才的团队是最重要的，严格说算不上是团队，也没必要强调团队，更注重的应该是员工的个人创造力，千万别让团队束缚住员工的头脑，当然应该有的纪律和合作也是不可少的。如果企业既有创造型员工也有操作型员工，那可将团队建设重点放到操作型员工身上。需要注意的一点是，越聪明的人越倾向个人主义，这个情况，企业管理者要注意有的放矢。</p><p><br/></p>', '', '', '', '', '', '', '0', '0', 'Y', '1501300397');
INSERT INTO `tp_page` VALUES ('8', '企业文化', '', 'cultural', '', '', '', '<p>迪尔和肯尼迪把企业文化整个理论系统概述为5个要素，即企业环境、价值观、英雄人物、文化仪式和文化网络。</p><p>企业环境是指企业的性质、企业的经营方向、外部环境、企业的社会形象、与外界的联系等方面。它往往决定企业的行为。</p><p>价值观是指企业内成员对某个事件或某种行为好与坏、善与恶、正确与错误、是否值得仿效的一致认识。价值观是企业文化的核心，统一的价值观使企业内成员在判断自己行为时具有统一的标准，并以此来选择自己的行为。</p><p>英雄人物是指企业文化的核心人物或企业文化的人格化，其作用在于作为一种活的样板，给企业中其他员工提供可供仿效的榜样，对企业文化的形成和强化起着极为重要的作用。</p><p>文化仪式是指企业内的各种表彰、奖励活动、聚会以及文娱活动等，它可以把企业中发生的某些事情戏剧化和形象化，来生动的宣传和体现本企业的价值观，使人们通过这些生动活泼的活动来领会企业文化的内涵，使企业文化“寓教于乐”之中。</p><p>文化网络是指非正式的信息传递渠道，主要是传播文化信息。它是由某种非正式的组织和人群，以及某一特定场合所组成，它所传递出的信息往往能反映出职工的愿望和心态。</p><h3 style=\"font-family: &#39;sans serif&#39;, tahoma, verdana, helvetica; white-space: normal;\">产生</h3><p>企业领导者把文化的变化人的功能应用于企业，以解决现代企业管理中的问题，就有了企业文化。企业管理理论和企业文化管理理论都追求效益。但前者为追求效益而把人当作客体，后者为追求效益把文化概念自觉应用于企业，把具有丰富创造性的人作为管理理论的中心。这种指导思想反映到企业管理中去，就有了人们称之为企业文化的种种观念。</p><h3 style=\"font-family: &#39;sans serif&#39;, tahoma, verdana, helvetica; white-space: normal;\">认识</h3><p>从企业文化的现实出发，进行深入的调查研究，把握企业文化各种现象之间的本质联系。依据实践经验，从感认认识到理性认识，进行科学的概括、总结。</p><h3 style=\"font-family: &#39;sans serif&#39;, tahoma, verdana, helvetica; white-space: normal;\">意义</h3><p>一．企业文化能激发员工的使命感。不管是什么企业都有它的责任和使命，企业使命感是全体员工工作的目标和方向，是企业不断发展或前进的动力之源。</p><p>二．企业文化能凝聚员工的归属感。　企业文化的作用就是通过企业价值观的提炼和传播，让一群来自不同地方的人共同追求同一个梦想。</p><p>三．企业文化能加强员工的责任感。企业要通过大量的资料和文件宣传员工责任感的重要性，管理人员要给全体员工灌输责任意识，危机意识和团队意识，要让大家清楚地认识企业是全体员工共同的企业。</p><p>四．企业文化能赋予员工的荣誉感。每个人都要在自己的工作岗位，工作领域，多做贡献，多出成绩，多追求荣誉感。</p><p>五．企业文化能实现员工的成就感。一个企业的繁荣昌盛关系到每一个公司员工的生存，企业繁荣了，员工们就会引以为豪，会更积极努力的进取，荣耀越高，成就感就越大，越明显。</p><p><br/></p>', '', '', '', '', '', '', '0', '0', 'Y', '1501300429');
INSERT INTO `tp_page` VALUES ('9', '联系我们', '', 'contact', '', '', '', '<p style=\"word-wrap: break-word; font-family: &#39;sans serif&#39;, tahoma, verdana, helvetica; font-size: 12px; line-height: 18px; white-space: normal;\">QQ:798528133</p><p style=\"word-wrap: break-word; font-family: &#39;sans serif&#39;, tahoma, verdana, helvetica; font-size: 12px; line-height: 18px; white-space: normal;\">一智后台软件官方网站：http://www.xbapple.com</p><p><br/></p>', '', '', '', '', '', '', '0', '0', 'Y', '1501300520');
INSERT INTO `tp_page` VALUES ('10', '关于我们', '', 'about', '', '', '', '<p>关于我们</p>', '', '', '', '', '', '', '0', '0', 'Y', '1501300561');

-- ----------------------------
-- Table structure for `tp_question`
-- ----------------------------
DROP TABLE IF EXISTS `tp_question`;
CREATE TABLE `tp_question` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `user_id` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '用户',
  `scope` smallint(5) unsigned NOT NULL DEFAULT '0' COMMENT '所属分类',
  `username` varchar(100) NOT NULL DEFAULT '' COMMENT '用户名',
  `realname` varchar(50) NOT NULL DEFAULT '' COMMENT '真实姓名',
  `email` varchar(60) NOT NULL DEFAULT '' COMMENT '邮箱',
  `telephone` varchar(20) NOT NULL DEFAULT '' COMMENT '电话',
  `question` text NOT NULL COMMENT '内容',
  `contact_other` varchar(100) NOT NULL DEFAULT '' COMMENT '其它联系方式',
  `answer_status` enum('Y','N') NOT NULL DEFAULT 'N' COMMENT '回复状态',
  `answer_content` text NOT NULL COMMENT '回复内容',
  `status_is` enum('Y','N') NOT NULL DEFAULT 'Y' COMMENT '状态',
  `create_time` int(10) unsigned NOT NULL DEFAULT '0' COMMENT '发送时间',
  `company_name` varchar(100) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COMMENT='客服';

-- ----------------------------
-- Records of tp_question
-- ----------------------------
INSERT INTO `tp_question` VALUES ('3', '0', '0', '刘德华', '刘德华', '123@126.com', '13152639874', '看到留言请回电', '', 'N', '', 'Y', '0', '百度');
INSERT INTO `tp_question` VALUES ('8', '0', '0', '', '111111111111', '3434343434343434343434', '222222222222', '4445555555555555555555', '', 'N', '', 'Y', '1504851786', '44444444444444');
INSERT INTO `tp_question` VALUES ('9', '0', '0', '', '', '', '', '', '', 'N', '', 'Y', '1504920907', '');

-- ----------------------------
-- Table structure for `tp_role`
-- ----------------------------
DROP TABLE IF EXISTS `tp_role`;
CREATE TABLE `tp_role` (
  `ID` int(5) NOT NULL AUTO_INCREMENT,
  `Rolename` varchar(20) DEFAULT NULL COMMENT '角色名称',
  `Description` varchar(50) DEFAULT NULL COMMENT '用户组说明',
  `Competence` varchar(255) DEFAULT NULL COMMENT '用户组权限列表',
  `Status` tinyint(2) DEFAULT '0' COMMENT '用户组状态',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_role
-- ----------------------------
INSERT INTO `tp_role` VALUES ('1', '超级管理员', '拥有全部权限，网站主要管理人员', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '0', '2013-12-08 17:13:02');
INSERT INTO `tp_role` VALUES ('6', '业务员', '管理客户信息催款', '3,4,12,18,', '0', null);
INSERT INTO `tp_role` VALUES ('2', '普通管理员', '只拥有部分权限操作权限', '18,19,20,82,83,29,30,32,33,52,53,35,36,37,38,39,40,41,42,43,77,45,46,47,48,49,50,51,84,60,61,62,63,65,66,67,68,69,70,71,72,73,74,75,76,78,79,80,81,85,', '0', '2013-12-08 17:14:40');
INSERT INTO `tp_role` VALUES ('5', '财务部', '', '18,19,20,82,83,45,46,47,48,50,51,84,61,62,63,60,', '0', null);
INSERT INTO `tp_role` VALUES ('7', '维护员', '', '61,62,63,60,92,93,94,95,', '0', null);
INSERT INTO `tp_role` VALUES ('8', '客服', '', '102,103,104,105,', '0', null);

-- ----------------------------
-- Table structure for `tp_statis`
-- ----------------------------
DROP TABLE IF EXISTS `tp_statis`;
CREATE TABLE `tp_statis` (
  `ID` int(8) unsigned NOT NULL AUTO_INCREMENT,
  `Uid` int(8) DEFAULT '0',
  `Dtime` char(12) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_statis
-- ----------------------------
INSERT INTO `tp_statis` VALUES ('43', '1', '1504862443');

-- ----------------------------
-- Table structure for `tp_user`
-- ----------------------------
DROP TABLE IF EXISTS `tp_user`;
CREATE TABLE `tp_user` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Username` varchar(20) DEFAULT NULL COMMENT '用户名',
  `Password` char(40) DEFAULT NULL COMMENT '密码',
  `Email` varchar(30) DEFAULT NULL COMMENT '管理员Email',
  `Roleid` tinyint(2) DEFAULT '0' COMMENT '用户角色',
  `Status` tinyint(2) DEFAULT '0' COMMENT '状态',
  `Competence` varchar(255) DEFAULT NULL COMMENT '权限列表',
  `Description` varchar(50) DEFAULT NULL COMMENT '说明',
  `Loginarea` varchar(20) DEFAULT NULL COMMENT '最后登录地',
  `Logincount` int(5) DEFAULT '0' COMMENT '登录次数',
  `Loginip` varchar(30) DEFAULT NULL COMMENT '最后登录IP',
  `Logintime` datetime DEFAULT NULL COMMENT '最后登录时间',
  `Dtime` datetime DEFAULT NULL COMMENT '时间',
  `leader_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_user
-- ----------------------------
INSERT INTO `tp_user` VALUES ('1', 'admin', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'sssgu@qq.com', '7', '0', '2,3,4,5,7,8,9,10,12,13,14,15,18,24,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,25,26,27,28,82,83,19,20,110,115,116,117,21,22,23,45,46,47,48,118,119,84,49,50,51,', '超级管理员', 'IANA保留地址.', '496', '0.0.0.0', '2017-09-08 17:20:38', '2013-12-08 17:18:54', '0');
INSERT INTO `tp_user` VALUES ('15', 'hailinhd', '22148d3754f54a6183797ccf3f01cc8e4e2df0c6', 'hailinhd@163.com', '6', '0', '3,4,12,18,49,50,84,', '', '新疆乌鲁木齐市.电信', '2', '110.152.25.101', '2017-03-15 12:49:21', '2017-03-15 12:46:20', '1');
INSERT INTO `tp_user` VALUES ('8', '小张', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'wade@126.com', '2', '0', '65,66,67,68,69,70,71,72,73,74,75,76,78,79,80,81,85,', '', 'IANA保留地址.', '4', '0.0.0.0', '2017-02-21 17:35:09', '2016-12-03 10:35:21', '5');
INSERT INTO `tp_user` VALUES ('9', 'kobe', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'kobe@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '', '甘肃省兰州市.电信ADSL', '1', '61.178.84.19', '2017-02-22 14:27:21', '2017-02-22 14:26:59', '5');
INSERT INTO `tp_user` VALUES ('10', 'dede', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'dede@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '财务经理', '甘肃省兰州市.电信ADSL', '1', '61.178.84.19', '2017-02-23 08:29:39', '2017-02-23 08:27:51', '5');
INSERT INTO `tp_user` VALUES ('11', 'www', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'www@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '', null, '0', null, null, '2017-02-23 08:34:41', '1');
INSERT INTO `tp_user` VALUES ('12', 'AAA', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'AAA@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '', null, '0', null, null, '2017-02-23 08:45:14', '1');
INSERT INTO `tp_user` VALUES ('13', 'admin3', '1f82ea75c5cc526729e2d581aeb3aeccfef4407e', '595657735@qq.com', '5', '0', '18,19,20,82,83,45,46,47,48,50,51,84,61,62,63,60,', 'sdf', '吉林省长春市.电信', '1', '124.235.153.58', '2017-03-07 16:14:38', '2017-03-07 16:14:19', '5');
INSERT INTO `tp_user` VALUES ('16', 'aa', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'aa@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '', null, '0', null, null, '2017-06-07 12:08:45', '1');
INSERT INTO `tp_user` VALUES ('17', 'why', '10470c3b4b1fed12c3baac014be15fac67c6e815', 'wade@126.com', '7', '0', '61,62,63,60,92,93,94,95,', '', 'IANA保留地址.', '2', '0.0.0.0', '2017-07-12 11:52:48', '2017-07-12 11:49:12', '0');
INSERT INTO `tp_user` VALUES ('24', 'qqq', '10470c3b4b1fed12c3baac014be15fac67c6e815', '123456@126.com', '8', '0', '102,103,104,105,25,26,27,28,82,83,19,20,119,84,', '111', 'IANA保留地址.', '8', '0.0.0.0', '2017-08-30 16:58:27', '2017-08-19 10:09:17', '1');
INSERT INTO `tp_user` VALUES ('23', '123456', '10470c3b4b1fed12c3baac014be15fac67c6e815', '123456@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,21,22,23,24,25,26,27,28,18,19,20,82,83,45,46,47,48,49,50,51,84,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,', '', null, '0', null, null, '2017-08-16 14:43:47', '0');
INSERT INTO `tp_user` VALUES ('22', '211212', '10470c3b4b1fed12c3baac014be15fac67c6e815', '111@126.com', '1', '0', '2,3,4,5,7,8,9,10,12,13,14,15,18,24,61,62,63,60,92,93,94,95,99,100,98,97,102,103,104,105,25,26,27,28,82,83,19,20,21,22,23,45,46,47,48,118,84,49,50,51,', '', null, '0', null, null, '2017-08-16 14:42:24', '0');

-- ----------------------------
-- Table structure for `tp_with`
-- ----------------------------
DROP TABLE IF EXISTS `tp_with`;
CREATE TABLE `tp_with` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Uid` int(10) DEFAULT '0' COMMENT '户用ID',
  `Cid` int(10) DEFAULT '0' COMMENT '客户档案编号',
  `Wast` tinyint(4) DEFAULT NULL COMMENT '跟单类型',
  `NameId` tinyint(4) DEFAULT NULL COMMENT '跟单对象',
  `NextTime` datetime DEFAULT NULL COMMENT '下次联系时间',
  `RemindTime` datetime DEFAULT NULL COMMENT '提醒时间',
  `Status` tinyint(4) DEFAULT '0',
  `Remind` tinyint(2) DEFAULT '0' COMMENT '是否已完成',
  `Content` varchar(1000) DEFAULT NULL COMMENT '详细描述',
  `Dtime` datetime DEFAULT NULL COMMENT '添加时间',
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tp_with
-- ----------------------------
INSERT INTO `tp_with` VALUES ('1', '1', '6', '47', '6', '2014-01-09 01:59:30', '2014-01-08 23:40:00', '0', '0', '', '2014-01-07 19:43:01');
INSERT INTO `tp_with` VALUES ('2', '1', '6', '48', '6', '2014-01-24 23:59:00', '2014-01-08 23:40:00', '0', '0', '', '2014-01-07 19:43:12');
INSERT INTO `tp_with` VALUES ('3', '1', '5', '48', '5', '2014-01-09 00:00:00', '2014-01-08 23:40:00', '0', '1', '重要客户', '2014-01-07 19:43:36');
INSERT INTO `tp_with` VALUES ('8', '9', '12', '46', '13', '2014-01-09 00:00:00', '2014-01-09 00:00:00', '0', '0', '', '2014-01-08 14:39:36');
