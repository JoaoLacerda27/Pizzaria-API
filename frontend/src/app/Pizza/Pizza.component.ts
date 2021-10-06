import { Component, OnInit } from '@angular/core';
import { Pizza } from '../Models/Pizza';

@Component({
  selector: 'app-Pizza',
  templateUrl: './Pizza.component.html',
  styleUrls: ['./Pizza.component.css']
})
export class PizzaComponent implements OnInit {

  pizzas : Pizza[];

  constructor() { }

  ngOnInit() {
  }

}
