using System;

string especieAnimal = "";
string idAnimal = "";
string idadeAnimal = "";
string descricaoFisicaAnimal = "";
string descricaoPersonalidadeAnimal = "";
string nomeAnimal = "";

int maxPets = 8;
string? entradaUsuario;
string menuSelecionado = "";

string[,] nossosPets = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            especieAnimal = "cachorro";
            idAnimal = "c1";
            idadeAnimal = "2";
            descricaoFisicaAnimal = "golden retriever feminino de cor creme de tamanho médio, pesando cerca de 30Kg. domesticado.";
            descricaoPersonalidadeAnimal = "adora ter a barriga esfregada e gosta de correr atrás do rabo. dá muitos beijos.";
            nomeAnimal = "lola";
            break;

        case 1:
            especieAnimal = "cachorro";
            idAnimal = "c2";
            idadeAnimal = "9";
            descricaoFisicaAnimal = "grande golden retriever macho marrom-avermelhado pesando cerca de 38Kg, domesticado.";
            descricaoPersonalidadeAnimal = "adora que esfreguem as orelhas quando te cumprimenta na porta, ou a qualquer hora! adora se inclinar e dar abraços caninos.";
            nomeAnimal = "loki";
            break;

        case 2:
            especieAnimal = "gato";
            idAnimal = "g3";
            idadeAnimal = "1";
            descricaoFisicaAnimal = "pequena fêmea branca pesando cerca de 8Kg. Sabe usar caixa de areia.";
            descricaoPersonalidadeAnimal = "amigável";
            nomeAnimal = "puss";
            break;

        case 3:
            especieAnimal = "gato";
            idAnimal = "g4";
            idadeAnimal = "?";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            nomeAnimal = "";
            break;

        default:
            especieAnimal = "";
            idAnimal = "";
            idadeAnimal = "";
            descricaoFisicaAnimal = "";
            descricaoPersonalidadeAnimal = "";
            nomeAnimal = "";
            break;
    }

    nossosPets[i, 0] = "ID #: " + idAnimal;
    nossosPets[i, 1] = "Especie: " + especieAnimal;
    nossosPets[i, 2] = "Idade: " + idadeAnimal;
    nossosPets[i, 3] = "Nome: " + nomeAnimal;
    nossosPets[i, 4] = "Descrição fisica: " + descricaoFisicaAnimal;
    nossosPets[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
}

do
{
    Console.Clear();

    Console.WriteLine("Bem-vindo ao aplicativo Contoso PetFriends. Suas opções do menu principal são:");
    Console.WriteLine(" 1. Liste todas as nossas informações atuais sobre animais de estimação");
    Console.WriteLine(" 2. Adicione um novo amigo animal ao array nossosPets");
    Console.WriteLine(" 3. Certifique-se de que as idades dos animais e as descrições físicas estejam completas");
    Console.WriteLine(" 4. Certifique-se de que os apelidos dos animais e as descrições de personalidade estejam completos");
    Console.WriteLine(" 5. Edite a idade de um animal");
    Console.WriteLine(" 6. Edite a descrição da personalidade de um animal");
    Console.WriteLine(" 7. Exibir todos os gatos com uma característica específica");
    Console.WriteLine(" 8. Exibir todos os cães com uma característica específica");
    Console.WriteLine();
    Console.WriteLine("Digite o número da sua seleção (ou digite Sair para sair do programa)");

    entradaUsuario = Console.ReadLine();

    if (entradaUsuario != null)
    {
        menuSelecionado = entradaUsuario.ToLower();
    }

    Console.WriteLine($"Você selecionou a opção de menu {menuSelecionado}.");
    Console.WriteLine("Pressione a tecla Enter para continuar");

    entradaUsuario = Console.ReadLine();
    Console.Clear();

    switch(menuSelecionado)
    {
        case "1":
            Console.Clear();
            for(int i = 0; i < maxPets; i++)
            {
                if(nossosPets[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for(int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(nossosPets[i, j]);
                    }
                }
            }

            Console.WriteLine("\nPressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;
        
        case "2":
            string outroPet = "s";
            int contaPet = 0;

            for(int i = 0; i < maxPets; i++)
            {
                if(nossosPets[i, 0] != "ID #: ")
                {
                    contaPet++;
                }
            }

            if(contaPet < maxPets)
            {
                Console.WriteLine($"Atualmente temos {contaPet} pets que precisam de lares." +  
                $" Podemos gerenciar mais {(maxPets - contaPet)}");
            }

            while(outroPet == "s" && contaPet < maxPets)
            {
                bool validaEntrada = false;
                do
                {
                    Console.WriteLine("Digite 'cachorro' ou 'gato' para iniciar uma nova entrada");
                    entradaUsuario = Console.ReadLine();

                    if(entradaUsuario != null)
                    {
                        especieAnimal = entradaUsuario;
                        if(especieAnimal != "cachorro" && especieAnimal != "gato")
                        {
                            validaEntrada = false;
                        }
                        else{
                            validaEntrada = true;
                        }
                    }

                } while (validaEntrada == false);

                idAnimal = especieAnimal.Substring(0, 1) + (contaPet + 1).ToString();
                do
                {
                    int idadePet;
                    Console.WriteLine("Digite a idade do animal de estimação ou digite ? se desconhecido");
                    entradaUsuario = Console.ReadLine();

                    if(entradaUsuario != null)
                    {
                        idadeAnimal = entradaUsuario;
                        if(idadeAnimal != "?")
                        {
                            validaEntrada = int.TryParse(idadeAnimal, out idadePet);
                        }
                        else
                        {
                            validaEntrada = true;
                        }
                    }
                } while (validaEntrada == false);

                do
                {
                    Console.WriteLine("Insira uma descrição física do animal de estimação (tamanho, cor, sexo, peso, domesticado)");
                    entradaUsuario = Console.ReadLine();

                    if(entradaUsuario != null)
                    {
                        descricaoFisicaAnimal = entradaUsuario.ToLower();
                        if(descricaoFisicaAnimal == "")
                        {
                            descricaoFisicaAnimal = "n/a";
                        }
                    }
                } while (descricaoFisicaAnimal == "");

                do
                {
                    Console.WriteLine("Insira uma descrição da personalidade do animal de estimação (gostos ou desgostos, truques, nível de energia)");
                    entradaUsuario = Console.ReadLine();

                    if(entradaUsuario != null)
                    {
                        descricaoPersonalidadeAnimal = entradaUsuario.ToLower();
                        if(descricaoPersonalidadeAnimal == "")
                        {
                            descricaoPersonalidadeAnimal = "n/a";
                        }
                    }
                } while (descricaoPersonalidadeAnimal == "");

                do
                {
                    Console.WriteLine("Digite um apelido para o animal de estimação");
                    entradaUsuario = Console.ReadLine();

                    if(entradaUsuario != null)
                    {
                        nomeAnimal = entradaUsuario.ToLower();
                        if(nomeAnimal == "")
                        {
                            nomeAnimal = "n/a";
                        }
                    }
                } while (nomeAnimal == "");

                nossosPets[contaPet, 0] = "ID #: " + idAnimal;
                nossosPets[contaPet, 1] = "Especie: " + especieAnimal;
                nossosPets[contaPet, 2] = "Idade: " + idadeAnimal;
                nossosPets[contaPet, 3] = "Nome: " + nomeAnimal;
                nossosPets[contaPet, 4] = "Descrição fisica: " + descricaoFisicaAnimal;
                nossosPets[contaPet, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;

                contaPet++;
                if(contaPet < maxPets)
                {
                    Console.WriteLine("Você deseja inserir informações de outro animal de estimação (s/n)");
                    do
                    {
                        entradaUsuario = Console.ReadLine();
                        if (entradaUsuario != null)
                        {
                            outroPet = entradaUsuario.ToLower();
                        }
                    } while (outroPet != "s" && outroPet != "n");
                }
            }
            
            if(contaPet >= maxPets)
            {
                Console.WriteLine("Atingimos nosso limite de número de animais de estimação que podemos gerenciar.");
                Console.WriteLine("Pressione a tecla Enter para continuar");
                entradaUsuario = Console.ReadLine();
            }

            break;
        
        case "3":
            for(int i = 0; i < maxPets; i++)
            {
                if(nossosPets[i, 0] != "ID #: ")
                {
                    if(nossosPets[i, 2] == "Idade: " || nossosPets[i, 2] == "Idade: ?")
                    {
                        Console.WriteLine($"Entre com a idade para {nossosPets[i, 0]}");
                        entradaUsuario = Console.ReadLine();
                        bool validaIdade = false;
                        int idadePet;

                        do
                        {
                            #pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
                            idadeAnimal = entradaUsuario.Trim();
                            #pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
                            validaIdade = int.TryParse(idadeAnimal, out idadePet);

                            if(entradaUsuario != null)
                            {
                                if(validaIdade)
                                {
                                    nossosPets[i, 2] = "Idade: " + idadeAnimal;
                                }
                                else
                                {
                                    Console.WriteLine("Valor inválido!");
                                    Console.WriteLine($"Entre com a idade para {nossosPets[i, 0]}");
                                    entradaUsuario = Console.ReadLine();
                                }
                            }
                        } while (validaIdade == false);
                    }

                    if(nossosPets[i, 4] == "Descrição fisica: " || nossosPets[i, 4] == "Descrição fisica: n/a")
                    {
                        Console.WriteLine($"Insira uma descrição física para {nossosPets[i, 0]} "
                        + "(tamanho, cor, raça, sexo, peso, domesticado)");
                        entradaUsuario = Console.ReadLine();

                        do
                        {
                            if(entradaUsuario != null && entradaUsuario.Length > 3)
                            {
                                descricaoFisicaAnimal = entradaUsuario.ToLower();
                                nossosPets[i, 4] = "Descrição fisica: " + descricaoFisicaAnimal;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido!");
                                Console.WriteLine($"Insira uma descrição física para {nossosPets[i, 0]} "
                                + "(tamanho, cor, raça, sexo, peso, domesticado)");
                                entradaUsuario = Console.ReadLine();
                            }
                        } while (descricaoFisicaAnimal == "");
                    }
                }
                else
                {
                    Console.WriteLine("\nTodos animais estão com os dados de idade e descrição físicas completas.");
                    break;
                }
            }
            
            Console.WriteLine("Pressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;

        case "4":
            for(int i = 0; i < maxPets; i++)
            {
                if(nossosPets[i, 0] != "ID #: ")
                {
                    if(nossosPets[i, 3] == "Nome: " || nossosPets[i, 3] == "Nome: n/a")
                    {
                        do
                        {
                            Console.WriteLine($"Insira um nome para {nossosPets[i, 0]}");
                            entradaUsuario = Console.ReadLine();

                            if(entradaUsuario != null && entradaUsuario.Length > 1)
                            {
                                nomeAnimal = entradaUsuario.ToLower();
                                nossosPets[i, 3] = "Nome: " + nomeAnimal;
                            }
                            else
                            {
                                Console.WriteLine("\n Nome inválido!");
                            }
                        } while (nomeAnimal == "");
                    }
                    if(nossosPets[i, 5] == "Personalidade: " || nossosPets[i, 5] == "Personalidade: n/a")
                    {
                        do
                        {
                            Console.WriteLine($"Insira uma descrição de personalidade para {nossosPets[i, 0]}"
                            + "(gosta ou não gosta, truques, nível de energia)");
                            entradaUsuario = Console.ReadLine();

                            if(entradaUsuario != null &&  entradaUsuario.Length > 3)
                            {
                                descricaoPersonalidadeAnimal = entradaUsuario.ToLower();
                                nossosPets[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
                            }
                            else
                            {
                                Console.WriteLine("\nInsira um valor válido!");
                            }
                        } while (descricaoPersonalidadeAnimal == "");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Os campos de nome e personalidade estão completos para todos os nossos amigos.");
                    break;
                }
            }
            
            Console.WriteLine("Pressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("Este recurso do aplicativo estará disponível em breve - verifique novamente para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("Este recurso do aplicativo estará disponível em breve - verifique novamente para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("Este recurso do aplicativo estará disponível em breve - verifique novamente para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("Este recurso do aplicativo estará disponível em breve - verifique novamente para ver o progresso.");
            Console.WriteLine("Pressione a tecla Enter para continuar");
            entradaUsuario = Console.ReadLine();
            break;

        default:
            break;
    }
}
while (menuSelecionado != "sair");



