import axios from "axios";

export default{
  async obterTasks(){
    try{
      let response = await axios.get("http://localhost:5190/Controller/Queries/listar");
      console.log(response);
      return await response.data;
    }
    catch(error){
      if(error.response){
        let response = await axios.get("http://localhost:5190/Controller/Queries/listar");
        console.log(response.data.mensagem);
      };
    }
  },

  async obterTasksConcluidas(){

    try{
      let response = await axios.get("/Controller/Queries/concluidas");
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.get("/Controller/Queries/concluidas");
      console.log(response.data.mensagem);
    }
  },

  async obterTasksPendentes(){
    try{
      let response = await axios.get("/Controller/Queries/pendentes");
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.get("/Controller/Queries/pendentes");
      console.log(response.data.mensagem);
    }

  },

  async obterPorcentTasks(){

     try{
      let response = await axios.get("/Controller/Queries/porcent");;
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.get("/Controller/Queries/porcent");;
      console.log(response.data.mensagem);
    }
  },

  async enviandoDadosTasks(tarefaParaAdicionar){

    try{
      let response = await axios.post("/Controller/Command", tarefaParaAdicionar);
      console.log(response.data.mensagem);
      return response;
    }
    catch(error){
      if(error.response){
        let response = await axios.post("/Controller/Command", tarefaParaAdicionar);
        console.log(response.data.mensagem);
      };

    }
  },

  async deletarTaskPorId(id){
      try{
      let response = await axios.delete(`/Controller/Command/${id}`);
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.delete(`/Controller/Command/${id}`);
      console.log(response.data.mensagem);
    }
    ;
  },

  async atualizarConcluido(id, concluido) {
    try{
      let response = await axios.patch(`/Controller/Command/${id}`, concluido);
      console.log(response);
      return response.data;
    }

    catch{
      let response = await axios.patch(`/Controller/Command/${id}`, concluido);
      console.log(response.data.mensagem);
    }
  },

  //verbos date
  async obterDiaNumero(){
    try{
      let response = await axios.get("/Controller/Queries/diaNumero");
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.get("/Controller/Queries/diaNumero");
      console.log(response.data.mensagem);
    }
  },

  async obterDiaExtenso(){

    try{
      let response = await axios.get("/Controller/Queries/diaExtenso");
      console.log(response.data.mensagem);
      return await response.data;    }
    catch{
      let response = await axios.get("/Controller/Queries/diaExtenso");
      console.log(response.data.mensagem);
    }
  },

  async obterMesEAno(){
    try{
      let response = await axios.get("/Controller/Queries/mesEano");
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.get("/Controller/Queries/mesEano");
      console.log(response.data.mensagem);
    }
  },

  async obterEhoje(){
    try{
      let response = await axios.get("/Controller/Queries/Ehoje");
      console.log(response.data.mensagem);
      return await response.data;
    }
    catch{
      let response = await axios.get("/Controller/Queries/Ehoje​");
      console.log(response.data.mensagem);
    }
  },
}



