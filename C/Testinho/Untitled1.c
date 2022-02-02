int main()
{
     float p1, p2, media;
     
     printf("PROGRAMA PARA DEFINIR PERFIL DA PESSOA\n\n");
     
     printf("fdp");
     scanf("%f", &p1);
     
     printf("\n\nDigite seu ano de nascimento:");
     scanf("%f", &p2);
     
     media = (p1 + p2) / 2;

     printf("\n\nSua media eh %4.2f", media);
     getch();
     return 0;
     
}
