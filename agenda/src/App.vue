<script>
import BlocoMaior from './components/BlocoMaior.vue';
import BlocoMaiorRecolhido from './components/BlocoMaiorRecolhido.vue';
import BlocoMenor from './components/BlocoMenor.vue';
import BlocoMenorExpandido from './components/BlocoMenorExpandido.vue';
import tarefasServicos from '@/tarefasServicos';

export default{
  name: "App",

  data(){
    return{
      diaNp: 0,
      diap: "",
      mesEanop: "",
      isTodaypv: true,
      tarefasconcluidasp: 0,
      porcentagemp: 0,
      tarefaspendentesp: 0,

      concluidop: "",
      titulop: "",
      corpop: "",
      classep: "",
      horap: "",

      opAdicionarTarefa: false,
      opBlocoMenorExpandido: false,
      opExibirBlocoMaior: false,
      opBlocoMenor: false,


      listaTarefas: [],
    }
  },

  async mounted(){

    //tasks + blocoMenorExpandido
      this.listaTarefas = (await tarefasServicos.obterTasks()).data;
      console.log(this.listaTarefas)
      this.tarefasconcluidasp =  (await tarefasServicos.obterTasksConcluidas()).data;
      this.tarefaspendentesp =  (await tarefasServicos.obterTasksPendentes()).data;
      this.porcentagemp =  (await tarefasServicos.obterPorcentTasks()).data;

    //date
      this.diaNp =  (await tarefasServicos.obterDiaNumero()).data;
      this.diap =  (await tarefasServicos.obterDiaExtenso()).data;
      this.mesEanop =  (await tarefasServicos.obterMesEAno()).data;
      this.isTodaypv =  (await tarefasServicos.obterEhoje()).data;
    },

  methods:{
    async atualizar(){
      this.opBlocoMenorExpandido = false;
      this.opAdicionarTarefa = true
      this.listaTarefas = (await tarefasServicos.obterTasks()).data;
      this.tarefasconcluidasp =  (await tarefasServicos.obterTasksConcluidas()).data;
      this.tarefaspendentesp =  (await tarefasServicos.obterTasksPendentes()).data;
      this.porcentagemp =  (await tarefasServicos.obterPorcentTasks()).data;

    //date
      this.diaNp =  (await tarefasServicos.obterDiaNumero()).data;
      this.diap =  (await tarefasServicos.obterDiaExtenso()).data;
      this.mesEanop =  (await tarefasServicos.obterMesEAno()).data;
      this.isTodaypv =  (await tarefasServicos.obterEhoje()).data;

    }
  },

  components:{
        BlocoMenorExpandido,
        BlocoMenor,
        BlocoMaior,
        BlocoMaiorRecolhido,
  },
}
</script>

<template>

  <BlocoMaior v-if="opExibirBlocoMaior" :diaN="diaNp" :dia="diap" :mesEano="mesEanop" :isToday="isTodaypv" :tarefasConcluidas="tarefasconcluidasp" :porcentagem="porcentagemp" :tarefasPendentes="tarefaspendentesp" @update:opAdicionarTarefa="opBlocoMenorExpandido = true" @update:opExibirBlocoMaior="opExibirBlocoMaior=false; opBlocoMenor = false" >
      <BlocoMenor v-show="opBlocoMenor" :listaTarefas="listaTarefas" @update:opCheckBox="atualizar()"></BlocoMenor>
      <BlocoMenorExpandido v-if="opBlocoMenorExpandido" @salva:pagina="atualizar()" @cancel:task="opBlocoMenorExpandido=false"> </BlocoMenorExpandido>
  </BlocoMaior>
  <BlocoMaiorRecolhido v-else :diaN="diaNp" :diaExtenso="diap" :mesEano="mesEanop" :isToday="isTodaypv" @update:opDetalhes="opExibirBlocoMaior=true; opBlocoMenor = true"></BlocoMaiorRecolhido>


</template>

<style>

body {
  display: block;
  margin: 0;
  background: #f6faf4;
  font-family: system-ui, -apple-system, "Segoe UI", Roboto, sans-serif;
  color: #1f2d1f;
}

#app {
  box-sizing: border-box;
  width: 100%;
  max-width: 488px;
  margin: 0 auto;
  padding: 24px 24px 48px;
  text-align: left;

  display: flex;
  flex-direction: column;
  gap: 12px;
}

/* Todo bloco (maior, recolhido, formulário e tarefas) ocupa a mesma largura e entra com uma animação suave */
#app > * {
  box-sizing: border-box;
  width: 100%;
  flex-shrink: 0;
  animation: surgir 0.2s ease-out;
}

@keyframes surgir {
  from {
    opacity: 0;
    transform: translateY(-6px);
  }
  to {
    opacity: 1;
    transform: none;
  }
}

</style>
