#include <iostream>
#include <unistd.h>
#include <stdio.h>

int main() {
    std:: cout <<"Hello Mundo!";
}

int main() {
    pid_t pid = fork();
    if (pid == 0) {
       _exit(0);
    }
    printf("pai: %d, filho: %d\n", getpid(), pid);
    fflush(stdout);
    sleep(60);
    return 0;
}