import { Pizza } from "./Pizza";

export class Cliente {
    id: number;
    firstname: string;
    lastname: string;
    usuario: string;
    cidade: string;
    estado: string;
    cep: number;
    quantidade: number;
    total: number;
    pizza: Pizza;
}
