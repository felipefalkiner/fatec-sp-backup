option explicit
dim variavel ' todas as vari�veis em arquivos VBS s�o do tipo variant
dim testetecla
variavel=0
do while variavel<4
testetecla=msgbox ("Teste de uso do VBS - Continua o teste???",3,"Voc� clicou tantas vezes:" & variavel)
variavel=variavel + 1
if testetecla = 7 then
msgbox "Clicou em n�o"
wscript.quit
end if
if testetecla =2 then wscript.quit
loop