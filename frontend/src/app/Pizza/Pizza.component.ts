import { Component, OnInit } from '@angular/core';
import { Pizza } from '../Models/Pizza';
import { PizzaService } from '../Services/pizza.service';

@Component({
  selector: 'app-Pizza',
  templateUrl: './Pizza.component.html',
  styleUrls: ['./Pizza.component.css']
})
export class PizzaComponent implements OnInit {

  pizzas : any;
  erro : any;

  constructor(private pizzaService: PizzaService) {
    this.getPizza();
   }

  ngOnInit() {
  }

  getPizza(){
    this.pizzaService.listarPizzas().subscribe(
      (data : Pizza )=>{
        this.pizzas = data;
        console.log('Variavel que preenchemos: ',this.pizzas);
        console.log('Data recebido: ', data)
    }, (error : any) =>{
      this.erro = error;
      console.error('ERROR' , error);
    });
  }

}
