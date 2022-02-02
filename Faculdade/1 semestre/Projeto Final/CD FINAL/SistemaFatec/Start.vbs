option explicit
dim VarShell, varData, frase, novapasta
dim objFSO, Wshs
dim testetecla

testetecla = msgbox ("Caso você queira fazer alterações no Sistema de Alunos por favor clique em Sim para que um backup seja feito."&chr(13)&chr(13)& "Caso queira apenas consultar, clique em Não (CUIDADO! O BACKUP NÃO SERÁ FEITO!)." &chr(13)&chr(13)& "Para Fechar clique em Cancelar.",3,"LEIA COM ATENÇÃO")

set varShell =wscript.CreateObject("Wscript.Shell")

if testetecla = 6 then
varData="dia" & day(now) & "-" & month(now) & "-" & year(Now) & "hora" & hour(now) & "-" & minute(now) & "-" & second(now)
frase="cmd /k CD C:\& mkdir C:\SistemaFatec\BKPs\" & varData & "& exit"
VarShell.run frase,1,true

novapasta="C:\SistemaFatec\BKPs\" & varData & "\Backup.accdb"

Set objFSO = CreateObject("Scripting.FileSystemObject")
Set Wshs = WScript.CreateObject("WScript.Shell")
objFSO.CopyFile "C:\SistemaFatec\Sistema.accdb" , novapasta
msgbox "Arquivo de Backup feito!"
end if

if testetecla = 7 then
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set Wshs = WScript.CreateObject("WScript.Shell")
msgbox "Backup NÃO FEITO! Cuidado com modificações"
end if


if testetecla = 2 then wscript.quit



varShell.run ("""msaccess.exe""C:\SistemaFatec\Sistema.accdb"),3,true