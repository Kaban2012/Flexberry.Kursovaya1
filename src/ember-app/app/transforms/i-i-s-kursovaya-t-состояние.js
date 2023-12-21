import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import tСостояниеEnum from '../enums/i-i-s-kursovaya-t-состояние';

export default FlexberryEnum.extend({
  enum: tСостояниеEnum,
  sourceType: 'IIS.Kursovaya.tСостояние'
});
