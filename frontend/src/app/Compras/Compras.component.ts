import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { Observable } from 'rxjs';
import { Pizza } from '../Models/Pizza';
import { ClienteService } from '../Services/cliente.service';

@Component({
  selector: 'app-Compras',
  templateUrl: './Compras.component.html',
  styleUrls: ['./Compras.component.css']
})
export class ComprasComponent implements OnInit {

  pizzas : any;
  erro : any;
  id : any;
  inscricao : Subscription;

  public formCliente: FormGroup;

  constructor(private formBuilder: FormBuilder, 
    private clienteService : ClienteService, 
    private route : ActivatedRoute) {

   }


  ngOnInit() {
    this.createForm(new Cliente());

    this.id = this.route.snapshot.paramMap.get('id');

    this.getPizza();
  
  }

  getPizza(){
    this.clienteService.listarPizza(this.id).subscribe(
      (data : Pizza )=>{
        this.pizzas = data;
    }, (error : any) =>{
      this.erro = error;
      console.error('ERROR' , error);
    });
  }

  createForm(cliente: Cliente){
    this.formCliente = this.formBuilder.group({
      nome: [cliente.nome, Validators.required],
      sobrenome: [cliente.sobrenome, Validators.required],
      usuario: [cliente.usuario, Validators.required],
      cidade: [cliente.cidade, Validators.required],
      estado: [cliente.estado, Validators.required],
      cep: [cliente.cep, [Validators.required, Validators.minLength(8)]],
      pizza: [cliente.pizza],
      quantidade: [cliente.quantidade, Validators.required],
      total: [cliente.total]
    });

  }

  onSubmit(){
    if(this.formCliente.valid){
      console.log(this.formCliente.value);
    } else{
      console.log("formulário inválido");
      Object.keys(this.formCliente.controls).forEach(campo => {
        console.log(campo);
        const controle = this.formCliente.get(campo);
        controle?.markAsDirty();
      });

    }
    this.formCliente.reset(new Cliente());
  }
}

export class Cliente {
  nome: string = '';
  sobrenome: string = '';
  usuario: string = '';
  cidade: string = '';
  estado: string = '';
  cep: number = 0;
  pizza: string = '';
  quantidade: number = 1;
  total: number = 0;
}


