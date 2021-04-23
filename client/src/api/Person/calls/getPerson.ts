import axios from "axios";
import { Person } from "src/models";

export async function getPerson(): Promise<Person> {
  const result = await axios({
    method: "GET",
    url: "api/Person"
  });
  return result.data;
}
