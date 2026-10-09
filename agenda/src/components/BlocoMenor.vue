<script>

export default{
    data(){
        return{
            titulo: "titulo",
            corpo:"corpo",
            hora: "00:00",
            concluido: true,
            watchPath: "/watchpic.png",
            classe: "classe"
        }
    }
}
</script>
<template>
    
    <div v-if="!concluido" class="blocoMenorPendente">
       <div class="titulo">{{ titulo }}</div>
        <input class="checkbox" type="checkbox" v-model="concluido">  
        <img :src="watchPath" alt="imagem de um relogio" class="imgRelogio"></img>
        <div class="corpo">{{ corpo }}</div>
        <div class="classe">{{ classe }}</div>
        <div class="hora">{{ hora }}</div>
    </div>
    
    <div v-else class="blocoMenorConcluido">
        <div class="titulo">{{ titulo }}</div>
        <input class="checkbox" type="checkbox" v-model="concluido">  
        <img :src="watchPath" alt="imagem de um relogio" class="imgRelogio"></img>
        <div class="corpo">{{ corpo }}</div>
        <div class="classe">{{ classe }}</div>
        <div class="hora">{{ hora }}</div>
        
    </div>
</template>

<style scoped>
.blocoMenorPendente{
  position: relative;
  width: 300px;
  height: 50px;
  box-sizing: border-box;
  padding: 4px 12px;
  background: #fff;
  border: 1px solid #cfe5c8;
  border-radius: 12px;

  display: grid;
  grid-template-columns: 24px 1fr auto auto;
  grid-template-rows: 1fr 1fr;
  column-gap: 8px;
  align-items: center;
}

.blocoMenorConcluido{
  position: relative;
  width: 300px;
  height: 50px;
  box-sizing: border-box;
  padding: 4px 12px;
  background: rgba(46, 204, 113, 0.25);
  border: 1px solid #4a7c68;
  border-radius: 12px;

  display: grid;
  grid-template-columns: 24px 1fr auto auto;
  grid-template-rows: 1fr 1fr;
  column-gap: 8px;
  align-items: center;
  text-decoration: line-through;

}

.titulo{
  color: #2d6a4f;
}
.checkbox{
 grid-column: 1;
  grid-row: 1 / 3;
  width: 18px;
  height: 18px;
  margin: 0;
  cursor: pointer;
  accent-color: #4a7c68;
}

.imgRelogio{
  grid-column: 3;
  grid-row: 2;
  width: 14px;
  height: 14px;
  object-fit: contain;
  opacity: 0.7;
  justify-self: end;
}

.corpo{
   grid-column: 2;
  grid-row: 2;
  font-size: 14px;
  line-height: 1;
  color: #6b7a6b;
  min-width: 0;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}
.classe{
  grid-column: 3 / 5;
  grid-row: 1;
  justify-self: end;
  padding: 1px 8px;
  font-size: 11px;
  border-radius: 999px;
  background: #eaf7e4;
  color: #4a7c68;
}

.hora{
  grid-column: 4;
  grid-row: 2;
  font-size: 12px;
  line-height: 1;
  color: #6b7a6b;
}
</style>