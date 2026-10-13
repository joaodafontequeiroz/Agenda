<script>
export default{
    data(){
        return{
            adicionarTarefa: "+ Adicionar tarefa",
            fechar: "Fechar",
            contTarefas: "1",
        }
    },

    props: {
      diaN:{
        type: Number,
        default: 10
      },
      dia:{
        type: String,
        default: "Sexta-Feira",
      },
      mesEano:{
        type: String,
        default: "fevereiro de 2006",
      },
      isToday: {
        type: Boolean,
        default: true,
      },
      tarefasConcluidas:{
        type: Number,
        default: 2,
      },
      porcentagem: {
        type: Number,
        default: 67
      },
      tarefasPendentes: {
        type: Number,
        default: 1,
      } ,
    },

    emits: ['update:opAdicionarTarefa, update:opExibirBlocoMaior'],
}
</script>

<template>
    <div class="blocoMaior">
        <div class="lista">
            <slot></slot>
        </div>
        <div class="dia" :value="dia">{{ dia }}</div>
        <div class="mesEano" :value="mesEano">{{mesEano}}</div>
        <button style="button" class="adicionarTarefa" @click="$emit('update:opAdicionarTarefa', true)">{{adicionarTarefa}}</button>
        <button style="button" class="fechar" @click="$emit('update:opExibirBlocoMaior', false)">{{fechar}}</button>
        <div class="isToday" :value="isToday">{{isToday}}</div>
        <div class="Ndia" value="diaN">{{ diaN }}</div>
        <div class="tarefas">tarefas a fazer</div>
        <div class="porcentagem" :value="porcentagem">{{porcentagem}}</div>
        <div class="barra" :style="{'--progresso': porcentagem + '%'}"></div>
        <div class="tituloBarra">tarefas concluidas: {{tarefasConcluidas}} de {{tarefasPendentes}}</div>
        <div class="pendente">{{tarefasPendentes}} tarefa pendente</div>
    </div>
</template>

<style scoped>

.blocoMaior {
  width: 440px;
  box-sizing: border-box;
  background: linear-gradient(#eaf7e4 124px, #fff 124px);
  border: 1px solid #cfe5c8;
  border-radius: 16px;
  overflow: hidden;
  font-family: inherit;

  display: grid;
  grid-template-columns: 20px auto auto auto 1fr auto 20px;
  grid-template-rows: 20px 26px 18px 34px 6px 20px auto minmax(120px, auto) auto auto 16px;
}

.Ndia {
  grid-column: 2;
  grid-row: 2 / 4;
  align-self: center;
  margin-right: 12px;
  font-size: 40px;
  font-weight: 700;
  line-height: 1;
  color: #4a7c68;
}

.dia {
  grid-column: 3;
  grid-row: 2;
  align-self: end;
  font-size: 20px;
  font-weight: 600;
  line-height: 1;
  color: #1f2d1f;
}

.isToday {
  grid-column: 4;
  grid-row: 2;
  align-self: end;
  margin-left: 10px;
  padding: 2px 10px;
  font-size: 11px;
  font-weight: 600;
  color: #4a7c68;
  background: #dbeed3;
  border-radius: 999px;
}

.mesEano {
  grid-column: 3 / 5;
  grid-row: 3;
  font-size: 13px;
  line-height: 1.2;
  color: #6b7a6b;
}

.tituloBarra {
  grid-column: 2 / 5;
  grid-row: 4;
  align-self: end;
  margin-bottom: 6px;
  font-size: 13px;
  line-height: 1;
  color: #6b7a6b;
  white-space: nowrap;
}

.porcentagem {
  grid-column: 3 / 7;
  grid-row: 4;
  justify-self: end;
  align-self: end;
  margin-bottom: 6px;
  font-size: 13px;
  font-weight: 600;
  color: #4a7c68;
}

.barra {
  --progresso: 25%;
  grid-column: 2 / 7;
  grid-row: 5;
  background: linear-gradient(to right, #4a7c68 var(--progresso), #cfe0c9 var(--progresso));
  border-radius: 999px;
  font-size: 0;
}

.tarefas {
  grid-column: 2 / 5;
  grid-row: 7;
  margin: 16px 0 12px;
  font-size: 14px;
  font-weight: 600;
  color: #1f2d1f;
}

.pendente {
  grid-column: 5 / 7;
  grid-row: 7;
  justify-self: end;
  margin: 16px 0 12px;
  font-size: 12px;
  color: #6b7a6b;
}

.lista {
  grid-column: 2 / 7;
  grid-row: 8;
  display: flex;
  flex-direction: column;
  gap: 12px;
  padding-bottom: 8px;
}

.adicionarTarefa {
  grid-column: 2 / 7;
  grid-row: 9;
  justify-self: start;
  padding: 8px 0;
  font-family: inherit;
  font-size: 14px;
  color: #4a7c68;
  background: none;
  border: none;
  cursor: pointer;
}

.adicionarTarefa:hover {
  text-decoration: underline;
}

.fechar {
  grid-column: 5 / 7;
  grid-row: 10;
  justify-self: end;
  margin-top: 12px;
  padding: 8px 20px;
  font-family: inherit;
  font-size: 14px;
  color: #1f2d1f;
  background: #fff;
  border: 1px solid #ddd;
  border-radius: 10px;
  cursor: pointer;
}

.fechar:hover {
  background: #f3f3f3;
}
</style>
