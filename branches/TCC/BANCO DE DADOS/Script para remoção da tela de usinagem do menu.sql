begin trans

delete from menu where id_menu = 22
delete from submenu where id_menu_filho = 22

print 'DONE!'

end trans