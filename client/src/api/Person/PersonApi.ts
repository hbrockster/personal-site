import { IPersonApi } from "./IPersonApi";
import axios from 'axios';
import { getPerson, getName } from "@/api/Person/calls";

axios.defaults.baseURL = 'https://localhost:5001/';

export class PersonApi implements IPersonApi {
    getPerson = getPerson;
    getName = getName;
}