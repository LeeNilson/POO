#include <cstdlib>
#include <iostream>
#include <string>

struct Cargo {
    std::string Titulo;
    double Salario;
};

struct Pessoa{
    std::string Nome;
    int Idade;
    Cargo cargo;
};

// Função principal ou  ponto de entrada do programa
int main() {   
    Cargo prof{"Full Stack", 4000.00};
    Pessoa p {"Susana", 30, prof};
    std::cout <<p.Nome<<""<<p.Idade<<""<< p.cargo.Titulo;; 
    return 0;
}