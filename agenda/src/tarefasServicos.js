import axios from "axios";

export default{
  async obter(){

    return await axios.get("http://localhost:5190/Routes/TaskRoutes/todas");
  }
}
