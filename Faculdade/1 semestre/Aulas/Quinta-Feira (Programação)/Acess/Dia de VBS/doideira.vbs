option explicit 'Obriga a declarar todas as vari�veis
on error resume next 'Se ocorrer algum erro, pula p/ pr�xima instru��o
dim varShell
wscript.Echo "O B AAAA! VAMOS BAGUN�AR TUUUUDOOO..." & chr(13) & "pressione OK para zoar..."
Set varShell =wscript.CreateObject("WScript.Shell")
do
wscript.sleep 200 'dorme por 200 milissegundos
varShell.sendkeys "{NUMLOCK}"
wscript.sleep 100
varShell.sendkeys "{CAPSLOCK}"
wscript.sleep 100
varShell.sendkeys "{sCROLLLOCK}"
wscript.sleep 200
varShell.sendkeys "{sCROLLLOCK}"
wscript.sleep 100
varShell.sendkeys "{CAPSLOCK}"
wscript.sleep 100
varShell.sendkeys "{NUMLOCK}"
loop ' looping infinito...
wscript.Echo "testando!... vamos ver se sai do looping..."