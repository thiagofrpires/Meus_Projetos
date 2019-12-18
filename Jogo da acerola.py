from random import randint

print('Olá, meu nome é Thiago. Descobri onde tem acerola aqui em Caxias')
print('Ela fica num terreno sem dono, e peguei muitas acerolas... MUITAS')

random = randint(0, 100)
resposta = 0;
tentativa = 10;
while resposta != random:
    resposta = input('Advinha quantas acerolas eu peguei: ')
    if resposta.isnumeric():
        resposta = int(resposta)
        tentativa = tentativa - 1
        if resposta == random:
            print('')
            print('Acertou miserávi! As acerolas eram {} e você ainda tinha {} chances.'.format(random, tentativa))
            print('')
            break;
        else:
            print('')
            if resposta > random:
                print('Não mano, peguei menos acerolas que isso')
                print('Se eu pudesse pegaria mais, só tinha dois bolsos haha')
            else:
                print('Cê é louco? peguei bem mais acerolas!!!')
                print('Tenta aí de novo, se acertar te dou algumas haha')
            print('Tenta aí, te dou mais {} chances.'.format(tentativa))
            print('')
        if tentativa == 0:
            print('')
            print('Não conseguiu acertar kkkk, você perdeu!')
            print('')
            break;

print('#### Fim do Jogo ####')
