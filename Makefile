WEBMIN_FW_TCP_INCOMING = 22 80 443 12321

COMMON_OVERLAYS = tkl-webcp nginx confconsole-lamp
COMMON_CONF = tkl-webcp

include $(FAB_PATH)/common/mk/turnkey/mysql.mk
include $(FAB_PATH)/common/mk/turnkey.mk
