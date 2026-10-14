<script>

export default{
    data(){
        return{
            watchPath: "/watchpic.png",
        }
    },

    methods:{
        apagarTask(id) {
          const i = this.listaTarefas.findIndex(t => t.id === id);
          if (i !== -1) {
           this.listaTarefas.splice(i, 1);
          }
        },
    },


    props:{
      listaTarefas: Array,
    },

    emits: ['update:opCheckBox'],
}
</script>
<template>


    <div v-for="tarefas in listaTarefas" :key="tarefas.id">
      <div v-if="!tarefas.concluido" class="blocoMenorPendente">
        <div class="titulo">{{ tarefas.titulo }}</div>
        <input class="checkbox" type="checkbox" :checked="tarefas.concluido" @click="tarefas.concluido = !tarefas.concluido">
        <img class="excluir" src="/fechar.png" alt="imagem de um icone de fechar" @click="apagarTask(tarefas.id)">
        <img :src="watchPath" alt="imagem de um relogio" class="imgRelogio">
        <div class="corpo">{{tarefas.corpo}}</div>
        <div class="classe">{{ tarefas.classe }}</div>
        <div class="hora">{{ tarefas.hora }}</div>
      </div>
    </div>



    <div v-for="tarefas in listaTarefas" :key="tarefas.id">
    <div v-if="tarefas.concluido" class="blocoMenorConcluido">
        <div class="titulo">{{ tarefas.titulo }}</div>
        <input class="checkbox" type="checkbox" :checked="tarefas.concluido" @click="tarefas.concluido = !tarefas.concluido">
        <img class="excluir" src="/fechar.png" alt="imagem de um icone de fechar" @click="apagarTask(tarefas.id)">
        <img :src="watchPath" alt="imagem de um relogio" class="imgRelogio">
        <div class="corpo">{{tarefas.corpo}}</div>
        <div class="classe">{{ tarefas.classe }}</div>
        <div class="hora">{{ tarefas.hora }}</div>
      </div>
  </div>


</template>

<style scoped>

/* Wrappers do v-for sem card (v-if falso) não ocupam espaço nem geram gap */
div:empty {
  display: none;
}

/* ===== Card (pendente e concluído) ===== */
.blocoMenorPendente,
.blocoMenorConcluido {
  position: relative;
  width: 100%;
  min-height: 58px;
  box-sizing: border-box;
  padding: 10px 10px 10px 14px;
  border-radius: 12px;

  display: grid;
  grid-template-columns: 22px 1fr auto auto 22px;
  grid-template-rows: auto auto;
  column-gap: 10px;
  row-gap: 4px;
  align-items: center;

  transition: box-shadow 0.15s ease, border-color 0.15s ease;
}

.blocoMenorPendente {
  background: #fff;
  border: 1px solid #cfe5c8;
}

.blocoMenorConcluido {
  background: rgba(46, 204, 113, 0.18);
  border: 1px solid #4a7c68;
}

.blocoMenorPendente:hover,
.blocoMenorConcluido:hover {
  box-shadow: 0 2px 8px rgba(74, 124, 104, 0.15);
}

/* ===== Checkbox ===== */
.checkbox {
  grid-column: 1;
  grid-row: 1 / 3;
  align-self: center;
  width: 18px;
  height: 18px;
  margin: 0;
  cursor: pointer;
  accent-color: #4a7c68;
}

/* ===== Título ===== */
.titulo {
  grid-column: 2;
  grid-row: 1;
  min-width: 0;
  font-size: 15px;
  font-weight: 600;
  line-height: 1.3;
  color: #2d6a4f;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

/* ===== Corpo ===== */
.corpo {
  grid-column: 2;
  grid-row: 2;
  min-width: 0;
  font-size: 13px;
  line-height: 1.3;
  color: #6b7a6b;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

/* Riscado só no texto principal das concluídas */
.blocoMenorConcluido .titulo,
.blocoMenorConcluido .corpo {
  text-decoration: line-through;
  text-decoration-color: rgba(45, 106, 79, 0.6);
}

.blocoMenorConcluido .titulo {
  color: #4a7c68;
}

.blocoMenorConcluido .corpo {
  color: #7d8c7d;
}

/* ===== Tag de classe (pessoal, casa, trabalho) ===== */
.classe {
  grid-column: 3 / 5;
  grid-row: 1;
  justify-self: end;
  padding: 2px 10px;
  font-size: 11px;
  font-weight: 600;
  line-height: 1.5;
  text-transform: capitalize;
  white-space: nowrap;
  border-radius: 999px;
  background: #eaf7e4;
  color: #4a7c68;
}

.classe:empty {
  display: none;
}

/* ===== Relógio + hora ===== */
.imgRelogio {
  grid-column: 3;
  grid-row: 2;
  justify-self: end;
  width: 14px;
  height: 14px;
  margin-right: -6px;
  object-fit: contain;
  opacity: 0.7;
}

.hora {
  grid-column: 4;
  grid-row: 2;
  justify-self: end;
  font-size: 12px;
  line-height: 1.3;
  font-variant-numeric: tabular-nums;
  color: #6b7a6b;
}

/* Sem hora preenchida, esconde também o ícone do relógio */
.blocoMenorPendente:has(.hora:empty) .imgRelogio,
.blocoMenorConcluido:has(.hora:empty) .imgRelogio {
  display: none;
}

/* ===== Botão excluir ===== */
.excluir {
  grid-column: 5;
  grid-row: 1 / 3;
  align-self: center;
  justify-self: end;
  box-sizing: content-box;
  width: 14px;
  height: 14px;
  padding: 4px;
  object-fit: contain;
  border-radius: 50%;
  opacity: 0.5;
  cursor: pointer;
  transition: opacity 0.15s ease, background-color 0.15s ease;
}

.excluir:hover {
  opacity: 1;
  background-color: rgba(0, 0, 0, 0.07);
}
</style>
