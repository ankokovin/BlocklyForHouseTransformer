# BlocklyForHouseTransformer

Транслятор для [BlocklyForHouse](https://github.com/ankokovin/BlocklyForHouse) c xml в python

Расчитан на использование с версией [0.1.2](https://ankokovin.github.io/BlocklyForHouse/version/0.1.2/index.html)

Создан как Лабораторная работа №5 "Паттерны поведения: интерпретатор".

В командном проекте скорее всего использован не будет:
1. Заказчик не требует раздельного перевода xml в python
2. Даже если потребуется выполнение трансформации - логиченее всего использовать возможности самой библиотеки Blockly. 2 варианта:
    1. использовать node-blockly
    2. использовать docker с образом браузера
    
Но всё же, если что - это вариант.
## Docs
[BlocklyForHouse.Transform](BlocklyForHouseTransformer/docs/BlocklyForHouse.Transform.md)
