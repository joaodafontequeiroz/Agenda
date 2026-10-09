<script>
export default{
    data(){
        return{

        }
    }
}
</script>

<template>
    <div class="blocoMaiorRecolhido">
        <div class="dia">dia</div>
        <div class="titulo">diaNumero</div>
        <div class="titulo2">data</div>
        <div class="data">Hoje</div>
        <div class="expandir">Detalhes</div>
    </div>
</template>

<style scoped>
  .blocoMaiorRecolhido {
  width: 440px;
  box-sizing: border-box;
  background: #eaf7e4;
  border: 1px solid #cfe5c8;
  border-radius: 16px;
  font-family: inherit;

  display: grid;
  grid-template-columns: 20px auto auto auto 1fr auto 20px;
  grid-template-rows: 20px 26px 18px 20px;
}

.dia {
  grid-column: 2;
  grid-row: 2 / 4;
  align-self: center;
  margin-right: 12px;
  font-size: 40px;
  font-weight: 700;
  line-height: 1;
  color: #4a7c68;
}

.titulo {
  grid-column: 3;
  grid-row: 2;
  align-self: end;
  font-size: 20px;
  font-weight: 600;
  line-height: 1;
  color: #1f2d1f;
}

.titulo2 {
  grid-column: 3 / 5;
  grid-row: 3;
  font-size: 13px;
  line-height: 1.2;
  color: #6b7a6b;
}

.data {
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

.expandir {
  grid-column: 6;
  grid-row: 2 / 4;
  align-self: center;
  padding: 6px 14px;
  font-family: inherit;
  font-size: 13px;
  font-weight: 600;
  color: #4a7c68;
  background: #fff;
  border: 1px solid #cfe5c8;
  border-radius: 999px;
  cursor: pointer;
}

.expandir:hover {
  background: #4a7c68;
  color: #fff;
}
</style>