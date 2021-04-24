import { Person } from "@/models";
import { IPersonApi } from "./IPersonApi";
import axios from 'axios';

axios.defaults.baseURL = 'https://localhost:5001/';

export class PersonApi implements IPersonApi {
    async getPerson(): Promise<Person> {
      const result = await axios({
          method: 'GET',
          url: 'api/person'
      });
      return new Person(result.data);
    }
    
}