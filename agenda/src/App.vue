<script>
import BlocoMaior from './components/BlocoMaior.vue';
import BlocoMaiorRecolhido from './components/BlocoMaiorRecolhido.vue';
import BlocoMenor from './components/BlocoMenor.vue';
import BlocoMenorExpandido from './components/BlocoMenorExpandido.vue';

export default{
  name: "App",

  data(){
    return{
      diaNp: Number,
      diap: "",
      mesEanop: "",
      isTodaypv: "",
      tarefasconcluidasp: "",
      porcentagemp: "",
      tarefaspendentesp: "",

      concluidop: "",
      titulop: "",
      corpop: "",
      classep: "",
      horap: "",

      opAdicionarTarefa: Boolean,
      opBlocoMenorExpandido:{
        type: Boolean,
        default: false,
      },
      opExibirBlocoMaior: Boolean,
      opBlocoMenor: Boolean,


      listaTarefas: [
  {
    concluido: false,
    titulo: "Academia",
    corpo: "Treino de pernas e cardio",
    classe: "Saúde",
    hora: "07:00"
  },
  {
    concluido: true,
    titulo: "Reunião Diária",
    corpo: "Alinhamento sobre a nova API",
    classe: "Trabalho",
    hora: "09:30"
  },
  {
    concluido: false,
    titulo: "Estudar Vue.js",
    corpo: "Revisar diretivas e componentes",
    classe: "Estudo",
    hora: "20:00"
  }
],
    }
  },

  methods:{

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

  <BlocoMaior v-if="opExibirBlocoMaior" :diaN="diaNp" :dia="diap" :mesEano="mesEanop" :isToday="isTodayp" :tarefasConcluidas="tarefasconcluidasp" :porcentagem="porcentagemp" :tarefasPendentes="tarefaspendentesp" @update:opAdicionarTarefa="opBlocoMenorExpandido = true" @update:opExibirBlocoMaior="opExibirBlocoMaior=false; opBlocoMenor = false" >
    <BlocoMenor v-show="opBlocoMenor" @update:opCheckBox="(op) => {this.listaTarefas.concluido.push(op)}" v-for="(tarefas, index) in listaTarefas"
      :key = "index"
      :concluido="tarefas.concluido"
      :titulo="tarefas.titulo"
      :corpo="tarefas.corpo"
      :classe="tarefas.classe"
      :hora="tarefas.hora"></BlocoMenor>
      <BlocoMenorExpandido v-if="opBlocoMenorExpandido" @salva:pagina="(pacote) => {this.listaTarefas.push(pacote); opBlocoMenorExpandido = false; opAdicionarTarefa = true}" @cancel:task="opBlocoMenorExpandido=false"> </BlocoMenorExpandido>
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
